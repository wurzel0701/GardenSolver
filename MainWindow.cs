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

        private Planter? m_currentSelected = null;

        public MainWindow()
        {
            InitializeComponent();
            SetupPlanterList();
            ClearWindow();
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

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            SavePlanterData();
            UpdatePlanterList();
        }

        private void SetupPlanterList()
        {
            listPlanters.View = View.Details;
            listPlanters.GridLines = true;
            listPlanters.LabelEdit = false;
            listPlanters.AllowColumnReorder = false;
            listPlanters.MultiSelect = false;
            listPlanters.FullRowSelect = true;

            Size listSize = listPlanters.Size;
            int sizeSplit = (listSize.Width / 9);
            listPlanters.Columns.Clear();
            listPlanters.Columns.Add("Name", sizeSplit * 3, HorizontalAlignment.Center);
            listPlanters.Columns.Add("Nährstoffe", sizeSplit * 2, HorizontalAlignment.Center);
            listPlanters.Columns.Add("Größe", sizeSplit * 2, HorizontalAlignment.Center);
            listPlanters.Columns.Add("#Pflanzen", -2, HorizontalAlignment.Center);

            UpdatePlanterList();
        }

        private void UpdatePlanterList()
        {
            listPlanters.Items.Clear();

            ListViewItem listViewItem;
            foreach (Planter plant in m_createdPlanters)
            {
                listViewItem = new ListViewItem(plant.Name);
                listViewItem.SubItems.Add(plant.PlanterNutrition.ToString());
                listViewItem.SubItems.Add(plant.m_length.ToString() + " x " + plant.m_width);
                listViewItem.SubItems.Add(plant.PlantAmount.ToString());

                listPlanters.Items.Add(listViewItem);
            }

            ClearWindow();
        }

        private void ClearWindow() 
        {
            m_textName.Text = string.Empty;
            m_textName.Enabled = false;

            m_textBoxLength.Text = string.Empty;
            m_textBoxWidth.Text = string.Empty;

            m_gBNutrition.Enabled = false;
            m_gBPlacement.Enabled = false;
            m_gBSize.Enabled = false;

            m_btAccept.Enabled = false;
            m_btAbort.Enabled = false;
        }

        private void SavePlanterData()
        {
            if (m_currentSelected == null)
            {
                return;
            }
            m_currentSelected.Name = m_textName.Text;

            m_currentSelected.m_length = float.Parse(m_textBoxLength.Text);
            m_currentSelected.m_width = float.Parse(m_textBoxWidth.Text);

            if (m_radioButtonLow.Checked)
            {
                m_currentSelected.PlanterNutrition = NutritionRequirementsEnum.LOW;
            }
            else if (m_radioButtonMedium.Checked)
            {
                m_currentSelected.PlanterNutrition = NutritionRequirementsEnum.MEDIUM;
            }
            else 
            {
                m_currentSelected.PlanterNutrition = NutritionRequirementsEnum.HIGH;
            }

            m_currentSelected.IsOutside = m_rBOutside.Checked;
        }

        private void ShowPlanterData()
        {
            if (m_currentSelected == null) 
            {
                return;
            }

            m_gBNutrition.Enabled = true;
            m_gBPlacement.Enabled = true;
            m_gBSize.Enabled = true;
            m_textName.Enabled = true;

            m_radioButtonLow.Enabled = true;
            m_radioButtonMedium.Enabled = true;

            m_textName.Text = m_currentSelected.Name;
            switch (m_currentSelected.PlanterNutrition)
            {
                case NutritionRequirementsEnum.LOW:
                    m_radioButtonLow.Checked = true;
                    break;
                case NutritionRequirementsEnum.MEDIUM:
                    m_radioButtonMedium.Checked = true;
                    break;
                case NutritionRequirementsEnum.HIGH:
                    m_radioButtonHigh.Checked = true;
                    break;
            }

            foreach (string selected in m_currentSelected.ChoosenPlantTypes) 
            {
                PlantType type = PlantTypeLibrary.GetPlantTypeOfName(selected);
                if (type != null) 
                {
                    if (type.NutritionRequirements == NutritionRequirementsEnum.MEDIUM)
                    {
                        m_radioButtonLow.Enabled = false;
                    }
                    if (type.NutritionRequirements == NutritionRequirementsEnum.HIGH)
                    {
                        m_radioButtonLow.Enabled = false;
                        m_radioButtonMedium.Enabled = false;
                        break;
                    }
                }
                
            }

            m_textBoxLength.Text = m_currentSelected.m_length.ToString();
            m_textBoxWidth.Text = m_currentSelected.m_width.ToString();

            if (m_currentSelected.IsOutside)
            {
                m_rBOutside.Checked = true;
            }
            else
            {
                m_rBInside.Checked = true;
            }

            m_btAbort.Enabled = true;
            m_btAccept.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPlanters.SelectedIndices.Count == 0)
            {
                m_deleteButton.Enabled = false;
                m_currentSelected = null;
                ClearWindow();
                return;
            }
            int selectedIndex = listPlanters.SelectedIndices[0];
            m_currentSelected = m_createdPlanters[selectedIndex];
            ShowPlanterData();
            m_deleteButton.Enabled = true;
        }

        private void m_newButton_Click(object sender, EventArgs e)
        {
            Planter planter = new Planter(NutritionRequirementsEnum.LOW, "Neues Beet", true, 1.2f, 3);
            m_createdPlanters.Add(planter);
            UpdatePlanterList();
        }

        private void m_deleteButton_Click(object sender, EventArgs e)
        {
            m_deleteButton.Enabled = false;
            if (listPlanters.SelectedIndices.Count <= 0)
            {
                return;
            }

            m_createdPlanters.RemoveAt(listPlanters.SelectedIndices[0]);
            UpdatePlanterList();
            ClearWindow();
        }

        private void m_btAbort_Click(object sender, EventArgs e)
        {
            ShowPlanterData();
        }
    }
}
