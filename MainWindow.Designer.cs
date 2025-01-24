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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            splitContainer1 = new SplitContainer();
            groupBox6 = new GroupBox();
            listGreenhouse = new ListBox();
            groupBox5 = new GroupBox();
            listOutside = new ListBox();
            splitContainer2 = new SplitContainer();
            splitContainer7 = new SplitContainer();
            textName = new TextBox();
            buttonAbort = new Button();
            label1 = new Label();
            groupBoxPlacement = new GroupBox();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            groupBoxSize = new GroupBox();
            textBox2 = new TextBox();
            textBoxLength = new TextBox();
            groupBoxNutrition = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            buttonCreate = new Button();
            groupBox4 = new GroupBox();
            textBoxInfo = new TextBox();
            listSelectedPlants = new ListBox();
            buttonChoose = new Button();
            listAvailablePlants = new ListBox();
            textBoxPlantSearch = new TextBox();
            splitContainer3 = new SplitContainer();
            listBox2 = new ListBox();
            splitContainer4 = new SplitContainer();
            splitContainer5 = new SplitContainer();
            textBox3 = new TextBox();
            splitContainer6 = new SplitContainer();
            listBox3 = new ListBox();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabDefinePlanter = new TabPage();
            tabPlantTypes = new TabPage();
            tabMovePlants = new TabPage();
            tabSuggestions = new TabPage();
            tabPlants = new TabPage();
            tabPlacement = new TabPage();
            tabPrinting = new TabPage();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            debugWindowToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            groupBoxPlacement.SuspendLayout();
            groupBoxSize.SuspendLayout();
            groupBoxNutrition.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.SuspendLayout();
            tabControl1.SuspendLayout();
            tabDefinePlanter.SuspendLayout();
            tabPlantTypes.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            splitContainer1.Panel1.Controls.Add(groupBox6);
            splitContainer1.Panel1.Controls.Add(groupBox5);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            // 
            // groupBox6
            // 
            resources.ApplyResources(groupBox6, "groupBox6");
            groupBox6.Controls.Add(listGreenhouse);
            groupBox6.Name = "groupBox6";
            groupBox6.TabStop = false;
            // 
            // listGreenhouse
            // 
            resources.ApplyResources(listGreenhouse, "listGreenhouse");
            listGreenhouse.FormattingEnabled = true;
            listGreenhouse.Name = "listGreenhouse";
            listGreenhouse.SelectedIndexChanged += listGreenhouse_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.Controls.Add(listOutside);
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // listOutside
            // 
            resources.ApplyResources(listOutside, "listOutside");
            listOutside.FormattingEnabled = true;
            listOutside.Name = "listOutside";
            listOutside.SelectedIndexChanged += listOutside_SelectedIndexChanged;
            // 
            // splitContainer2
            // 
            resources.ApplyResources(splitContainer2, "splitContainer2");
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(splitContainer2.Panel1, "splitContainer2.Panel1");
            splitContainer2.Panel1.Controls.Add(splitContainer7);
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(splitContainer2.Panel2, "splitContainer2.Panel2");
            splitContainer2.Panel2.Controls.Add(listSelectedPlants);
            splitContainer2.Panel2.Controls.Add(buttonChoose);
            splitContainer2.Panel2.Controls.Add(listAvailablePlants);
            splitContainer2.Panel2.Controls.Add(textBoxPlantSearch);
            // 
            // splitContainer7
            // 
            resources.ApplyResources(splitContainer7, "splitContainer7");
            splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            resources.ApplyResources(splitContainer7.Panel1, "splitContainer7.Panel1");
            splitContainer7.Panel1.Controls.Add(textName);
            splitContainer7.Panel1.Controls.Add(buttonAbort);
            splitContainer7.Panel1.Controls.Add(label1);
            splitContainer7.Panel1.Controls.Add(groupBoxPlacement);
            splitContainer7.Panel1.Controls.Add(groupBoxSize);
            splitContainer7.Panel1.Controls.Add(groupBoxNutrition);
            splitContainer7.Panel1.Controls.Add(buttonCreate);
            // 
            // splitContainer7.Panel2
            // 
            resources.ApplyResources(splitContainer7.Panel2, "splitContainer7.Panel2");
            splitContainer7.Panel2.Controls.Add(groupBox4);
            // 
            // textName
            // 
            resources.ApplyResources(textName, "textName");
            textName.Name = "textName";
            // 
            // buttonAbort
            // 
            resources.ApplyResources(buttonAbort, "buttonAbort");
            buttonAbort.Name = "buttonAbort";
            buttonAbort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // groupBoxPlacement
            // 
            resources.ApplyResources(groupBoxPlacement, "groupBoxPlacement");
            groupBoxPlacement.Controls.Add(radioButton8);
            groupBoxPlacement.Controls.Add(radioButton9);
            groupBoxPlacement.Name = "groupBoxPlacement";
            groupBoxPlacement.TabStop = false;
            // 
            // radioButton8
            // 
            resources.ApplyResources(radioButton8, "radioButton8");
            radioButton8.Name = "radioButton8";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            resources.ApplyResources(radioButton9, "radioButton9");
            radioButton9.Checked = true;
            radioButton9.Name = "radioButton9";
            radioButton9.TabStop = true;
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // groupBoxSize
            // 
            resources.ApplyResources(groupBoxSize, "groupBoxSize");
            groupBoxSize.Controls.Add(textBox2);
            groupBoxSize.Controls.Add(textBoxLength);
            groupBoxSize.Name = "groupBoxSize";
            groupBoxSize.TabStop = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // textBoxLength
            // 
            resources.ApplyResources(textBoxLength, "textBoxLength");
            textBoxLength.Name = "textBoxLength";
            // 
            // groupBoxNutrition
            // 
            resources.ApplyResources(groupBoxNutrition, "groupBoxNutrition");
            groupBoxNutrition.Controls.Add(radioButton3);
            groupBoxNutrition.Controls.Add(radioButton2);
            groupBoxNutrition.Controls.Add(radioButton1);
            groupBoxNutrition.Name = "groupBoxNutrition";
            groupBoxNutrition.TabStop = false;
            // 
            // radioButton3
            // 
            resources.ApplyResources(radioButton3, "radioButton3");
            radioButton3.Name = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.Name = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.Checked = true;
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            resources.ApplyResources(buttonCreate, "buttonCreate");
            buttonCreate.Name = "buttonCreate";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            resources.ApplyResources(groupBox4, "groupBox4");
            groupBox4.Controls.Add(textBoxInfo);
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // textBoxInfo
            // 
            resources.ApplyResources(textBoxInfo, "textBoxInfo");
            textBoxInfo.Name = "textBoxInfo";
            // 
            // listSelectedPlants
            // 
            resources.ApplyResources(listSelectedPlants, "listSelectedPlants");
            listSelectedPlants.FormattingEnabled = true;
            listSelectedPlants.Name = "listSelectedPlants";
            listSelectedPlants.SelectedIndexChanged += listSelectedPlants_SelectedIndexChanged;
            // 
            // buttonChoose
            // 
            resources.ApplyResources(buttonChoose, "buttonChoose");
            buttonChoose.Name = "buttonChoose";
            buttonChoose.UseVisualStyleBackColor = true;
            buttonChoose.Click += button2_Click;
            // 
            // listAvailablePlants
            // 
            resources.ApplyResources(listAvailablePlants, "listAvailablePlants");
            listAvailablePlants.FormattingEnabled = true;
            listAvailablePlants.Name = "listAvailablePlants";
            listAvailablePlants.SelectedIndexChanged += listAvailablePlants_SelectedIndexChanged;
            // 
            // textBoxPlantSearch
            // 
            resources.ApplyResources(textBoxPlantSearch, "textBoxPlantSearch");
            textBoxPlantSearch.Name = "textBoxPlantSearch";
            textBoxPlantSearch.Click += textBoxPlantSearch_Click;
            textBoxPlantSearch.TextChanged += textBoxPlantSearch_TextChanged;
            // 
            // splitContainer3
            // 
            resources.ApplyResources(splitContainer3, "splitContainer3");
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            resources.ApplyResources(splitContainer3.Panel1, "splitContainer3.Panel1");
            splitContainer3.Panel1.Controls.Add(listBox2);
            // 
            // splitContainer3.Panel2
            // 
            resources.ApplyResources(splitContainer3.Panel2, "splitContainer3.Panel2");
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            // 
            // listBox2
            // 
            resources.ApplyResources(listBox2, "listBox2");
            listBox2.FormattingEnabled = true;
            listBox2.Name = "listBox2";
            // 
            // splitContainer4
            // 
            resources.ApplyResources(splitContainer4, "splitContainer4");
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            resources.ApplyResources(splitContainer4.Panel1, "splitContainer4.Panel1");
            splitContainer4.Panel1.Controls.Add(splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            resources.ApplyResources(splitContainer4.Panel2, "splitContainer4.Panel2");
            splitContainer4.Panel2.Controls.Add(listBox1);
            // 
            // splitContainer5
            // 
            resources.ApplyResources(splitContainer5, "splitContainer5");
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            resources.ApplyResources(splitContainer5.Panel1, "splitContainer5.Panel1");
            splitContainer5.Panel1.Controls.Add(textBox3);
            // 
            // splitContainer5.Panel2
            // 
            resources.ApplyResources(splitContainer5.Panel2, "splitContainer5.Panel2");
            splitContainer5.Panel2.Controls.Add(splitContainer6);
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            // 
            // splitContainer6
            // 
            resources.ApplyResources(splitContainer6, "splitContainer6");
            splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            resources.ApplyResources(splitContainer6.Panel1, "splitContainer6.Panel1");
            splitContainer6.Panel1.Controls.Add(listBox3);
            // 
            // splitContainer6.Panel2
            // 
            resources.ApplyResources(splitContainer6.Panel2, "splitContainer6.Panel2");
            // 
            // listBox3
            // 
            resources.ApplyResources(listBox3, "listBox3");
            listBox3.FormattingEnabled = true;
            listBox3.Name = "listBox3";
            // 
            // listBox1
            // 
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.FormattingEnabled = true;
            listBox1.Name = "listBox1";
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
            tabDefinePlanter.Controls.Add(splitContainer1);
            tabDefinePlanter.Name = "tabDefinePlanter";
            tabDefinePlanter.UseVisualStyleBackColor = true;
            // 
            // tabPlantTypes
            // 
            resources.ApplyResources(tabPlantTypes, "tabPlantTypes");
            tabPlantTypes.Controls.Add(splitContainer3);
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
            // statusStrip1
            // 
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(toolStripStatusLabel1, "toolStripStatusLabel1");
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            resources.ApplyResources(toolStripProgressBar1, "toolStripProgressBar1");
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Name = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { debugWindowToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // debugWindowToolStripMenuItem
            // 
            resources.ApplyResources(debugWindowToolStripMenuItem, "debugWindowToolStripMenuItem");
            debugWindowToolStripMenuItem.Name = "debugWindowToolStripMenuItem";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel1.PerformLayout();
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            groupBoxPlacement.ResumeLayout(false);
            groupBoxPlacement.PerformLayout();
            groupBoxSize.ResumeLayout(false);
            groupBoxSize.PerformLayout();
            groupBoxNutrition.ResumeLayout(false);
            groupBoxNutrition.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabDefinePlanter.ResumeLayout(false);
            tabPlantTypes.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem debugWindowToolStripMenuItem;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private ListBox listBox2;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private TextBox textBox3;
        private SplitContainer splitContainer6;
        private ListBox listBox3;
        private ListBox listBox1;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private SplitContainer splitContainer7;
        private TextBox textName;
        private Button buttonAbort;
        private Label label1;
        private GroupBox groupBoxPlacement;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private GroupBox groupBoxSize;
        private TextBox textBox2;
        private TextBox textBoxLength;
        private GroupBox groupBoxNutrition;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button buttonCreate;
        private GroupBox groupBox4;
        private TextBox textBoxInfo;
        private ListBox listGreenhouse;
        private ListBox listOutside;
        private ListBox listSelectedPlants;
        private Button buttonChoose;
        private ListBox listAvailablePlants;
        private TextBox textBoxPlantSearch;
    }
}