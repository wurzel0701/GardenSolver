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
        private List<Planter> m_createdPlanters = new List<Planter> { };

        private Planter? m_currentPlanter = null;

        private NutritionRequirementsEnum m_currentNutrition = NutritionRequirementsEnum.UNSET;

        private List<string> m_currentPlants = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            tabControl1_SelectedIndexChanged(null, null);
        }

        private void UpdatePlantTypeList(bool keepSelection = true)
        {
            if (m_currentPlanter == null)
            {
                return;
            }

            string filterString = textBoxPlantSearch.Text.ToLower();

            if (!keepSelection)
            {
                m_currentPlants.Clear();
            }

            m_listPlantTypeView.Items.Clear();
            ListViewItem listViewItem;
            foreach (string plant in PlantTypeLibrary.AllPlantTypeNames)
            {
                if (filterString.Length > 0 && !(plant.ToLower().Contains(filterString)))
                {
                    //textBoxInfo.AppendText("Skipping plant " + plant + "\r\n");
                    continue;
                }

                listViewItem = new ListViewItem(plant);

                PlantType plantType = PlantTypeLibrary.GetPlantTypeOfName(plant);


                listViewItem.SubItems.Add(plantType.NutritionRequirements.ToString());
                listViewItem.SubItems.Add(plantType.PlantFamily.ToString());

                if ((int)plantType.NutritionRequirements > (int)m_currentNutrition)
                {
                    listViewItem.ForeColor = Color.LightGray;
                    listViewItem.BackColor = Color.Gray;
                    listViewItem.UseItemStyleForSubItems = true;
                    listViewItem.Tag = false;
                }
                else
                {
                    listViewItem.Tag = true;
                    if (keepSelection && m_currentPlants.Contains(plant))
                    {
                        listViewItem.Checked = true;
                    }
                }

                m_listPlantTypeView.Items.Add(listViewItem);
            }

        }

        private void textBoxPlantSearch_TextChanged(object sender, EventArgs e)
        {
            if (sender is not TextBox)
            {
                return;
            }

            textBoxInfo.AppendText("New text is " + textBoxPlantSearch.Text + "\r\n");
            string filter = textBoxPlantSearch.Text.ToLower();
            UpdatePlantTypeList(true);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            SavePlanterData();
            UpdatePlanterList();
        }

        private void SetupPlantTypeList()
        {
            m_listPlantTypeView.View = View.Details;

            m_listPlantTypeView.View = View.Details;
            m_listPlantTypeView.GridLines = true;
            m_listPlantTypeView.LabelEdit = false;
            m_listPlantTypeView.AllowColumnReorder = false;
            m_listPlantTypeView.MultiSelect = false;
            m_listPlantTypeView.FullRowSelect = true;
            m_listPlantTypeView.CheckBoxes = true;

            Size listSize = m_listPlantTypeView.Size;
            int sizeSplit = ((listSize.Width - 4 - SystemInformation.VerticalScrollBarWidth) / 7);
            m_listPlantTypeView.Columns.Clear();
            m_listPlantTypeView.Columns.Add("Name", sizeSplit * 3, HorizontalAlignment.Center);
            m_listPlantTypeView.Columns.Add("Nährstoffe", sizeSplit * 2, HorizontalAlignment.Center);
            m_listPlantTypeView.Columns.Add("Familie", sizeSplit * 2, HorizontalAlignment.Center);
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
            int sizeSplit = ((listSize.Width - 4 - SystemInformation.VerticalScrollBarWidth) / 9);
            listPlanters.Columns.Clear();
            listPlanters.Columns.Add("Name", sizeSplit * 3, HorizontalAlignment.Center);
            listPlanters.Columns.Add("Nährstoffe", sizeSplit * 2, HorizontalAlignment.Center);
            listPlanters.Columns.Add("Größe", sizeSplit * 2, HorizontalAlignment.Center);
            listPlanters.Columns.Add("#Pflanzen", sizeSplit * 2, HorizontalAlignment.Center);

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

            m_listPlantTypeView.Items.Clear();
            textBoxPlantSearch.Enabled = false;
        }

        private void SavePlanterData()
        {
            if (m_currentPlanter == null)
            {
                return;
            }
            m_currentPlanter.Name = m_textName.Text;

            m_currentPlanter.m_length = float.Parse(m_textBoxLength.Text);
            m_currentPlanter.m_width = float.Parse(m_textBoxWidth.Text);

            if (m_radioButtonLow.Checked)
            {
                m_currentPlanter.PlanterNutrition = NutritionRequirementsEnum.LOW;
            }
            else if (m_radioButtonMedium.Checked)
            {
                m_currentPlanter.PlanterNutrition = NutritionRequirementsEnum.MEDIUM;
            }
            else
            {
                m_currentPlanter.PlanterNutrition = NutritionRequirementsEnum.HIGH;
            }

            m_currentPlanter.IsOutside = m_rBOutside.Checked;

            m_currentPlanter.ChoosenPlantTypes.Clear();
            foreach (string plant in m_currentPlants)
            {
                m_currentPlanter.ChoosenPlantTypes.Add(plant);
            }
        }

        private void ShowPlanterData()
        {
            if (m_currentPlanter == null)
            {
                return;
            }

            m_gBNutrition.Enabled = true;
            m_gBPlacement.Enabled = true;
            m_gBSize.Enabled = true;
            m_textName.Enabled = true;

            m_radioButtonLow.Enabled = true;
            m_radioButtonMedium.Enabled = true;

            m_textName.Text = m_currentPlanter.Name;
            switch (m_currentPlanter.PlanterNutrition)
            {
                case NutritionRequirementsEnum.LOW:
                    m_radioButtonLow.Checked = true;
                    m_currentNutrition = NutritionRequirementsEnum.LOW;
                    break;
                case NutritionRequirementsEnum.MEDIUM:
                    m_radioButtonMedium.Checked = true;
                    m_currentNutrition = NutritionRequirementsEnum.MEDIUM;
                    break;
                case NutritionRequirementsEnum.HIGH:
                    m_radioButtonHigh.Checked = true;
                    m_currentNutrition = NutritionRequirementsEnum.HIGH;
                    break;
            }

            foreach (string selected in m_currentPlanter.ChoosenPlantTypes)
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

            m_textBoxLength.Text = m_currentPlanter.m_length.ToString();
            m_textBoxWidth.Text = m_currentPlanter.m_width.ToString();

            if (m_currentPlanter.IsOutside)
            {
                m_rBOutside.Checked = true;
            }
            else
            {
                m_rBInside.Checked = true;
            }

            m_btAbort.Enabled = true;
            m_btAccept.Enabled = true;

            m_currentPlants.Clear();
            foreach (string selected in m_currentPlanter.ChoosenPlantTypes)
            {
                m_currentPlants.Add(selected);
            }

            textBoxPlantSearch.Enabled = true;
            UpdatePlantTypeList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPlanters.SelectedIndices.Count == 0)
            {
                m_deleteButton.Enabled = false;
                m_currentPlanter = null;
                ClearWindow();
                return;
            }
            int selectedIndex = listPlanters.SelectedIndices[0];
            m_currentPlanter = m_createdPlanters[selectedIndex];
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

        private void OnNutritionChange(object sender, EventArgs e)
        {
            //Button changed by script
            RadioButton? rb = sender as RadioButton;

            if (rb == null)
            {
                return;
            }

            if (rb.Checked)
            {
                switch (rb.Tag)
                {
                    case "LOW":
                        m_currentNutrition = NutritionRequirementsEnum.LOW;
                        break;
                    case "MEDIUM":
                        m_currentNutrition = NutritionRequirementsEnum.MEDIUM;
                        break;
                    case "HIGH":
                        m_currentNutrition = NutritionRequirementsEnum.HIGH;
                        break;
                    default:
                        throw new Exception("The tag " + rb.Tag + " is undefined");
                }

                UpdatePlantTypeList(true);
            }


        }

        private void m_listPlantTypeView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (m_listPlantTypeView.Items[e.Index].Tag == null)
            {
                throw new Exception("The tag is not filled for this object, aborting");
            }

            bool available = (bool)m_listPlantTypeView.Items[e.Index].Tag;
            if (!available)
            {
                e.NewValue = e.CurrentValue;
            }
        }

        private void m_listPlantTypeView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                m_currentPlants.Add(e.Item.Text);
            }
            else
            {
                m_currentPlants.Remove(e.Item.Text);
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    //This is always ok to go here
                    break;
                case 1:
                    if (m_createdPlanters.Count == 0)
                    {
                        e.Cancel = true;
                    }
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void CalculateAllSuggestions() 
        {
            List<PlanterSuggestion> suggestions = null;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex) 
            {
                case 0:
                    SetupPlanterList();
                    SetupPlantTypeList();
                    ClearWindow();
                    break;
                case 1:
                    CalculateAllSuggestions();
                    break;
                default:
                    break;

            }
        }
    }
}
