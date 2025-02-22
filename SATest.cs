﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GardenSolver
{
    public partial class SATest : Form
    {
        private int[,] m_gridLayout;

        private int m_gridSize;

        private short[][] m_constraints;

        private string[] m_plantNames;

        private Dictionary<string, int> m_plantIDs = new Dictionary<string, int>();

        private Dictionary<int, int> m_requestedAmount = new Dictionary<int, int>();

        private float m_startingSigma = 0;

        private const float SIGMA_DECREASE = 0.985f;

        private const float MIN_SIGMA_STEP = 0.1f;

        private int m_iterationCount = 0;

        private int m_currentScore = 0;

        public SATest()
        {
            InitializeComponent();
            InitializeGrid(30, 10);
            InitializePlants();
            InitializeConstraints();
            CalculateParameter();
            CreateRandomGrid();
            m_currentScore = CalculateCost();
            outputBox.AppendText("Initial score is " + m_currentScore + "\r\n");
            int steps = (int)Math.Round(Math.Log(m_startingSigma / MIN_SIGMA_STEP, 2 - SIGMA_DECREASE));
            outputBox.AppendText("Initial sigma " + m_startingSigma + ", resulting in " + steps + "steps\r\n");
            outputBox.AppendText("Iteration per Step " + m_iterationCount + "\r\n");
        }

        public void Solve()
        {
            while (m_currentScore > 0) 
            {
                float sigma = m_startingSigma;
                Random rand = new Random();

                while (sigma > 0)
                {
                    //outputBox.AppendText("At " + sigma + " best starting solution is " + m_currentScore + "\r\n");
                    for (int i = 0; i < m_iterationCount; i++)
                    {
                        int x = rand.Next(0, m_gridLayout.GetLength(0));
                        int y = rand.Next(0, m_gridLayout.GetLength(1));
                        OptimisePoint(x, y, sigma);
                    }

                    if (sigma <= 0.1f)
                    {
                        sigma = 0;
                    }
                    else
                    {
                        sigma *= SIGMA_DECREASE;
                    }
                }

                if (m_currentScore > 0) 
                {
                    outputBox.AppendText("No solution found, restarting with higher sigma");
                    m_startingSigma *= 1.25f;
                }
            }

            outputBox.AppendText("End solution has score " + m_currentScore + "\r\n");

            for (int i = 0; i < m_plantNames.Length; i++) 
            {
                outputBox.AppendText(m_plantNames[i] + " has placement offset " + m_requestedAmount[i] + "\r\n");
            }

            Print();
        }

        public void Print() 
        {
            string[] startLetter = new string[m_plantNames.Length];
            for (int i = 0; i < m_plantNames.Length; i++) 
            {
                startLetter[i] = (m_plantNames[i]).Substring(0, 1).ToUpper();
            }

            for (int i = 0; i < m_gridLayout.GetLength(0); i++) 
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < m_gridLayout.GetLength(1); j++) 
                {
                    if (j > 0) 
                    {
                        sb.Append(" - ");
                    }

                    sb.Append(startLetter[m_gridLayout[i, j]] + "(" + (-CalculateCostGridPoint(i, j)) + ")");
                }

                outputBox.AppendText(sb.ToString() + "\r\n\r\n");
            }
        }

        private void InitializeGrid(int width, int length)
        {
            m_gridLayout = new int[Math.Max(width, length), Math.Min(length, width)];
            for (int i = 0; i < m_gridLayout.GetLength(0); i++)
            {
                for (int j = 0; j < m_gridLayout.GetLength(1); j++)
                {
                    m_gridLayout[i, j] = -1;
                }
            }
            m_gridSize = width * length;
        }

        private void InitializePlants()
        {
            m_plantNames = new string[] { "Gurke", "Kartoffel", "Mais", "Paprika", "Tomate" };

            for (int i = 0; i < m_plantNames.Length; i++)
            {
                m_plantIDs.Add(m_plantNames[i], i);
                m_requestedAmount.Add(i, (m_gridLayout.GetLength(0) * m_gridLayout.GetLength(1) / m_plantNames.Length));
            }
        }

        private void InitializeConstraints()
        {
            int amount = m_plantNames.Length;

            m_constraints = new short[amount][];

            for (int i = 0; i < amount; i++)
            {
                m_constraints[i] = new short[amount];

                for (int j = 0; j < amount; j++)
                {
                    short rating = PlantTypeLibrary.GetPlantRelation(m_plantNames[i], m_plantNames[j]);
                    m_constraints[i][j] = rating;
                }
            }
        }

        private void CalculateParameter()
        {
            m_startingSigma = 0;
            for (int i = 0; i < m_constraints.Length; i++)
            {
                for (int j = 0; j < m_constraints.Length; j++)
                {
                    m_startingSigma += Math.Abs(m_constraints[i][j]);
                }
            }
            m_startingSigma = (float)Math.Sqrt(m_startingSigma);

            m_iterationCount = (int)Math.Round(Math.Sqrt(m_gridSize) * m_startingSigma);
        }

        private void CreateRandomGrid()
        {
            Random rand = new Random();
            for (int i = 0; i < m_gridLayout.GetLength(0); i++)
            {
                for (int j = 0; j < m_gridLayout.GetLength(1); j++)
                {
                    int placed = rand.Next(0, m_plantNames.Length);
                    SetInGrid(i, j, placed);
                }
            }
        }

        private void SetInGrid(int x, int y, int index)
        {
            int current = m_gridLayout[x, y];
            if (current >= 0)
            {
                m_requestedAmount[current] += 1;
            }

            m_gridLayout[x, y] = index;
            m_requestedAmount[index] -= 1;
        }

        private int CalculateCost()
        {
            int score = 0;
            for (int i = 0; i < m_gridLayout.GetLength(0); i++)
            {
                for (int j = 0; j < m_gridLayout.GetLength(1); j++)
                {
                    int indScore = CalculateCostGridPoint(i, j);
                    score += indScore;
                    //outputBox.AppendText("Cost of note " + i + "/" + j + " is " + indScore + "\r\n"); 
                }
            }
            //outputBox.AppendText("Node score is " + score + "\r\n");

            for (int i = 0; i < m_plantNames.Length; i++)
            {
                //outputBox.AppendText("Point score for " + m_plantNames[i] + " is " + m_requestedAmount[i] + "\r\n");
                score += (m_requestedAmount[i] * m_requestedAmount[i]);
            }

            return score;
        }

        private int CalculateCostGridPoint(int i, int j)
        {
            int currentIndex = m_gridLayout[i, j];
            int otherIndex;

            int score = 0;

            if (i != 0)
            {
                otherIndex = m_gridLayout[i - 1, j];
                score -= m_constraints[currentIndex][otherIndex];
            }

            if ((i + 1) < m_gridLayout.GetLength(0))
            {
                otherIndex = m_gridLayout[i + 1, j];
                score -= m_constraints[currentIndex][otherIndex];
            }

            if (j != 0)
            {
                otherIndex = m_gridLayout[i, j - 1];
                score -= m_constraints[currentIndex][otherIndex];
            }

            if ((j + 1) < m_gridLayout.GetLength(1))
            {
                otherIndex = m_gridLayout[i, j + 1];
                score -= m_constraints[currentIndex][otherIndex];
            }

            return score;
        }

        private void OptimisePoint(int i, int j, float sigma)
        {
            int oldState = m_gridLayout[i, j];

            Random rand = new Random();
            int testState = oldState;
            while (testState == oldState) 
            {
                testState = rand.Next(0, m_plantNames.Length);
            }
            SetInGrid(i, j, testState);
            int testScore = CalculateCost();

            if (testScore < m_currentScore)
            {
                m_currentScore = testScore;
                //outputBox.AppendText("Improved score to " + m_currentScore + " with better solution\r\n");
            }
            else
            {
                int diff = testScore - m_currentScore;
                double probability = 1 / (1 + Math.Exp(diff / sigma));

                if (rand.NextDouble() <= probability)
                {
                    //Solution accepted
                    //outputBox.AppendText("Selected worse solution with " + diff + " at " + probability * 100 + "% chance\r\n");
                }
                else
                {
                    //Solution rejected, resetting
                    SetInGrid(i, j, oldState);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Solve();
        }
    }
}
