namespace GardenSolver
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Label label2;
            tabControl1 = new TabControl();
            tabDefinePlanter = new TabPage();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            comboBoxNutrition = new ComboBox();
            buttonNewPlanter = new Button();
            tabPlantTypes = new TabPage();
            tabMovePlants = new TabPage();
            tabSuggestions = new TabPage();
            tabPlants = new TabPage();
            tabPlacement = new TabPage();
            tabPrinting = new TabPage();
            label1 = new Label();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabDefinePlanter.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabDefinePlanter);
            tabControl1.Controls.Add(tabPlantTypes);
            tabControl1.Controls.Add(tabMovePlants);
            tabControl1.Controls.Add(tabSuggestions);
            tabControl1.Controls.Add(tabPlants);
            tabControl1.Controls.Add(tabPlacement);
            tabControl1.Controls.Add(tabPrinting);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabDefinePlanter
            // 
            resources.ApplyResources(tabDefinePlanter, "tabDefinePlanter");
            tabDefinePlanter.Controls.Add(checkBox1);
            tabDefinePlanter.Controls.Add(textBox2);
            tabDefinePlanter.Controls.Add(textBox1);
            tabDefinePlanter.Controls.Add(label2);
            tabDefinePlanter.Controls.Add(label1);
            tabDefinePlanter.Controls.Add(comboBoxNutrition);
            tabDefinePlanter.Controls.Add(buttonNewPlanter);
            tabDefinePlanter.Name = "tabDefinePlanter";
            tabDefinePlanter.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // comboBoxNutrition
            // 
            resources.ApplyResources(comboBoxNutrition, "comboBoxNutrition");
            comboBoxNutrition.FormattingEnabled = true;
            comboBoxNutrition.Items.AddRange(new object[] { resources.GetString("comboBoxNutrition.Items"), resources.GetString("comboBoxNutrition.Items1"), resources.GetString("comboBoxNutrition.Items2") });
            comboBoxNutrition.Name = "comboBoxNutrition";
            // 
            // buttonNewPlanter
            // 
            resources.ApplyResources(buttonNewPlanter, "buttonNewPlanter");
            buttonNewPlanter.Name = "buttonNewPlanter";
            buttonNewPlanter.UseVisualStyleBackColor = true;
            // 
            // tabPlantTypes
            // 
            resources.ApplyResources(tabPlantTypes, "tabPlantTypes");
            tabPlantTypes.Name = "tabPlantTypes";
            tabPlantTypes.UseVisualStyleBackColor = true;
            // 
            // tabMovePlants
            // 
            resources.ApplyResources(tabMovePlants, "tabMovePlants");
            tabMovePlants.Name = "tabMovePlants";
            tabMovePlants.UseVisualStyleBackColor = true;
            // 
            // tabSuggestions
            // 
            resources.ApplyResources(tabSuggestions, "tabSuggestions");
            tabSuggestions.Name = "tabSuggestions";
            tabSuggestions.UseVisualStyleBackColor = true;
            // 
            // tabPlants
            // 
            resources.ApplyResources(tabPlants, "tabPlants");
            tabPlants.Name = "tabPlants";
            tabPlants.UseVisualStyleBackColor = true;
            // 
            // tabPlacement
            // 
            resources.ApplyResources(tabPlacement, "tabPlacement");
            tabPlacement.Name = "tabPlacement";
            tabPlacement.UseVisualStyleBackColor = true;
            // 
            // tabPrinting
            // 
            resources.ApplyResources(tabPrinting, "tabPrinting");
            tabPrinting.Name = "tabPrinting";
            tabPrinting.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "MainWindow";
            tabControl1.ResumeLayout(false);
            tabDefinePlanter.ResumeLayout(false);
            tabDefinePlanter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDefinePlanter;
        private TabPage tabPlantTypes;
        private TabPage tabMovePlants;
        private TabPage tabSuggestions;
        private TabPage tabPlants;
        private TabPage tabPlacement;
        private TabPage tabPrinting;
        private ComboBox comboBoxNutrition;
        private Button buttonNewPlanter;
        private CheckBox checkBox1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}