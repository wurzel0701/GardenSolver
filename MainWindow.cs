using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenSolver
{
    public partial class MainWindow : Form
    {
        private List<string> m_availablePlants = new List<string>();

        private List<string> m_selectedPlants = new List<string>();

        private List<Planter> m_createdPlanters = new List<Planter> { };

        public MainWindow()
        {
            InitializeComponent();
            FillBoxes();
            SetupPlanterList();
        }

        private void FillBoxes()
        {

            listAvailablePlants.Items.Clear();
            //ListViewItem listViewItem;
            foreach (string plant in PlantTypeLibrary.AllPlantTypeNames)
            {
                //listViewItem = new ListViewItem(plant);

                //PlantType plantType = PlantTypeLibrary.GetPlantTypeOfName(plant);

                //listViewItem.SubItems.Add(plantType.PlantFamily.ToString());
                //listViewItem.SubItems.Add(plantType.NutritionRequirements.ToString());

                listAvailablePlants.Items.Add(plant);
                m_availablePlants.Add(plant);
            }

            listSelectedPlants.Items.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listAvailablePlants.SelectedIndex != -1)
            {
                //Transfer available to selected
                object item = listAvailablePlants.Items[listAvailablePlants.SelectedIndex];
                listAvailablePlants.Items.RemoveAt(listAvailablePlants.SelectedIndex);
                listSelectedPlants.Items.Add(item);
                m_availablePlants.Remove((string)item);
                m_selectedPlants.Add((string)item);
            }

            if (listSelectedPlants.SelectedIndex != -1)
            {
                //Transfer selected to available
                object item = listSelectedPlants.Items[listSelectedPlants.SelectedIndex];
                listSelectedPlants.Items.RemoveAt(listSelectedPlants.SelectedIndex);
                listAvailablePlants.Items.Add(item);
                m_selectedPlants.Remove((string)item);
                m_availablePlants.Add((string)item);
            }

            listSelectedPlants.SelectedItems.Clear();
            listAvailablePlants.SelectedItems.Clear();

            listSelectedPlants.Sorted = true;
            listAvailablePlants.Sorted = true;

            buttonChoose.Enabled = false;
        }

        private void listAvailablePlants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAvailablePlants.SelectedIndex != -1)
            {
                listSelectedPlants.SelectedItems.Clear();
                buttonChoose.Enabled = true;
                buttonChoose.Text = "Auswählen";
            }
        }

        private void listSelectedPlants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSelectedPlants.SelectedIndex != -1)
            {
                listAvailablePlants.SelectedItems.Clear();
                buttonChoose.Enabled = true;
                buttonChoose.Text = "Entfernen";
            }
        }

        private void textBoxPlantSearch_TextChanged(object sender, EventArgs e)
        {
            //textBoxInfo.AppendText("New text is " + textBoxPlantSearch.Text + "\r\n");
            string filter = textBoxPlantSearch.Text.ToLower();

            if (filter == string.Empty)
            {
                //Allow all
                listAvailablePlants.Items.Clear();
                foreach (string plant in m_availablePlants)
                {
                    listAvailablePlants.Items.Add(plant);
                }

                listSelectedPlants.Items.Clear();
                foreach (string plant in m_selectedPlants)
                {
                    listSelectedPlants.Items.Add(plant);
                }

                listAvailablePlants.Sorted = true;
                listSelectedPlants.Sorted = true;
            }
            else
            {
                //Filter for plant
                listAvailablePlants.Items.Clear();
                foreach (string plant in m_availablePlants)
                {
                    if (plant.ToLower().Contains(filter))
                    {
                        listAvailablePlants.Items.Add(plant);
                    }
                }

                listSelectedPlants.Items.Clear();
                foreach (string plant in m_selectedPlants)
                {
                    if (plant.ToLower().Contains(filter))
                    {
                        listSelectedPlants.Items.Add(plant);
                    }
                }

                listAvailablePlants.Sorted = true;
                listSelectedPlants.Sorted = true;
            }
        }

        private void textBoxPlantSearch_Click(object sender, EventArgs e)
        {
            textBoxPlantSearch.Text = string.Empty;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void SetupPlanterList() 
        {
            listPlanters.View = View.Details;
            listPlanters.GridLines = true;
            listPlanters.LabelEdit = false;
            listPlanters.AllowColumnReorder = false;

            listPlanters.Columns.Clear();
            listPlanters.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listPlanters.Columns.Add("Nährstoffe", -2, HorizontalAlignment.Center);
            listPlanters.Columns.Add("Größe", -2, HorizontalAlignment.Center);
            listPlanters.Columns.Add("Pflanztypen", -2, HorizontalAlignment.Center);

            UpdatePlanterList();
        }

        private void UpdatePlanterList() 
        {
            listPlanters.Items.Clear();

            listPlanters.Items.Add(new ListViewItem("Neues Beet"));

            ListViewItem listViewItem;
            foreach (Planter plant in m_createdPlanters) 
            {
                listViewItem = new ListViewItem(plant.Name);
                listViewItem.SubItems.Add(plant.PlanterNutrition.ToString());
                listViewItem.SubItems.Add(plant.m_length.ToString() + " x " + plant.m_width);
                listViewItem.SubItems.Add(plant.PlantAmount.ToString());

                listPlanters.Items.Add(listViewItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listPlanters.SelectedIndices[0];
            if (selectedIndex == 0)
            {

            }
            else 
            {

            }
        }
    }
}
