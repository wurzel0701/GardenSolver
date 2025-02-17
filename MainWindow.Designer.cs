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
            m_newButton = new Button();
            m_deleteButton = new Button();
            label2 = new Label();
            listPlanters = new ListView();
            splitContainer2 = new SplitContainer();
            splitContainer7 = new SplitContainer();
            m_textName = new TextBox();
            m_btAbort = new Button();
            label1 = new Label();
            m_gBPlacement = new GroupBox();
            m_rBInside = new RadioButton();
            m_rBOutside = new RadioButton();
            m_gBSize = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            m_textBoxWidth = new TextBox();
            m_textBoxLength = new TextBox();
            m_gBNutrition = new GroupBox();
            m_radioButtonHigh = new RadioButton();
            m_radioButtonMedium = new RadioButton();
            m_radioButtonLow = new RadioButton();
            m_btAccept = new Button();
            groupBox4 = new GroupBox();
            textBoxInfo = new TextBox();
            m_listPlantTypeView = new ListView();
            label5 = new Label();
            textBoxPlantSearch = new TextBox();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            listView1 = new ListView();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabDefinePlanter = new TabPage();
            tabPlantTypes = new TabPage();
            tabMovePlants = new TabPage();
            tabSuggestions = new TabPage();
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
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            m_gBPlacement.SuspendLayout();
            m_gBSize.SuspendLayout();
            m_gBNutrition.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(m_newButton);
            splitContainer1.Panel1.Controls.Add(m_deleteButton);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(listPlanters);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            // 
            // m_newButton
            // 
            resources.ApplyResources(m_newButton, "m_newButton");
            m_newButton.Name = "m_newButton";
            m_newButton.UseVisualStyleBackColor = true;
            m_newButton.Click += m_newButton_Click;
            // 
            // m_deleteButton
            // 
            resources.ApplyResources(m_deleteButton, "m_deleteButton");
            m_deleteButton.Name = "m_deleteButton";
            m_deleteButton.UseVisualStyleBackColor = true;
            m_deleteButton.Click += m_deleteButton_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // listPlanters
            // 
            resources.ApplyResources(listPlanters, "listPlanters");
            listPlanters.Name = "listPlanters";
            listPlanters.UseCompatibleStateImageBehavior = false;
            listPlanters.SelectedIndexChanged += listView1_SelectedIndexChanged;
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
            splitContainer2.Panel2.Controls.Add(m_listPlantTypeView);
            splitContainer2.Panel2.Controls.Add(label5);
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
            splitContainer7.Panel1.Controls.Add(m_textName);
            splitContainer7.Panel1.Controls.Add(m_btAbort);
            splitContainer7.Panel1.Controls.Add(label1);
            splitContainer7.Panel1.Controls.Add(m_gBPlacement);
            splitContainer7.Panel1.Controls.Add(m_gBSize);
            splitContainer7.Panel1.Controls.Add(m_gBNutrition);
            splitContainer7.Panel1.Controls.Add(m_btAccept);
            // 
            // splitContainer7.Panel2
            // 
            resources.ApplyResources(splitContainer7.Panel2, "splitContainer7.Panel2");
            splitContainer7.Panel2.Controls.Add(groupBox4);
            // 
            // m_textName
            // 
            resources.ApplyResources(m_textName, "m_textName");
            m_textName.Name = "m_textName";
            // 
            // m_btAbort
            // 
            resources.ApplyResources(m_btAbort, "m_btAbort");
            m_btAbort.Name = "m_btAbort";
            m_btAbort.UseVisualStyleBackColor = true;
            m_btAbort.Click += m_btAbort_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // m_gBPlacement
            // 
            resources.ApplyResources(m_gBPlacement, "m_gBPlacement");
            m_gBPlacement.Controls.Add(m_rBInside);
            m_gBPlacement.Controls.Add(m_rBOutside);
            m_gBPlacement.Name = "m_gBPlacement";
            m_gBPlacement.TabStop = false;
            // 
            // m_rBInside
            // 
            resources.ApplyResources(m_rBInside, "m_rBInside");
            m_rBInside.Name = "m_rBInside";
            m_rBInside.UseVisualStyleBackColor = true;
            // 
            // m_rBOutside
            // 
            resources.ApplyResources(m_rBOutside, "m_rBOutside");
            m_rBOutside.Checked = true;
            m_rBOutside.Name = "m_rBOutside";
            m_rBOutside.TabStop = true;
            m_rBOutside.UseVisualStyleBackColor = true;
            // 
            // m_gBSize
            // 
            resources.ApplyResources(m_gBSize, "m_gBSize");
            m_gBSize.Controls.Add(label4);
            m_gBSize.Controls.Add(label3);
            m_gBSize.Controls.Add(m_textBoxWidth);
            m_gBSize.Controls.Add(m_textBoxLength);
            m_gBSize.Name = "m_gBSize";
            m_gBSize.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // m_textBoxWidth
            // 
            resources.ApplyResources(m_textBoxWidth, "m_textBoxWidth");
            m_textBoxWidth.Name = "m_textBoxWidth";
            // 
            // m_textBoxLength
            // 
            resources.ApplyResources(m_textBoxLength, "m_textBoxLength");
            m_textBoxLength.Name = "m_textBoxLength";
            // 
            // m_gBNutrition
            // 
            resources.ApplyResources(m_gBNutrition, "m_gBNutrition");
            m_gBNutrition.Controls.Add(m_radioButtonHigh);
            m_gBNutrition.Controls.Add(m_radioButtonMedium);
            m_gBNutrition.Controls.Add(m_radioButtonLow);
            m_gBNutrition.Name = "m_gBNutrition";
            m_gBNutrition.TabStop = false;
            // 
            // m_radioButtonHigh
            // 
            resources.ApplyResources(m_radioButtonHigh, "m_radioButtonHigh");
            m_radioButtonHigh.Name = "m_radioButtonHigh";
            m_radioButtonHigh.Tag = "HIGH";
            m_radioButtonHigh.UseVisualStyleBackColor = true;
            m_radioButtonHigh.CheckedChanged += OnNutritionChange;
            // 
            // m_radioButtonMedium
            // 
            resources.ApplyResources(m_radioButtonMedium, "m_radioButtonMedium");
            m_radioButtonMedium.Name = "m_radioButtonMedium";
            m_radioButtonMedium.Tag = "MEDIUM";
            m_radioButtonMedium.UseVisualStyleBackColor = true;
            m_radioButtonMedium.CheckedChanged += OnNutritionChange;
            // 
            // m_radioButtonLow
            // 
            resources.ApplyResources(m_radioButtonLow, "m_radioButtonLow");
            m_radioButtonLow.Checked = true;
            m_radioButtonLow.Name = "m_radioButtonLow";
            m_radioButtonLow.TabStop = true;
            m_radioButtonLow.Tag = "LOW";
            m_radioButtonLow.UseVisualStyleBackColor = true;
            m_radioButtonLow.CheckedChanged += OnNutritionChange;
            // 
            // m_btAccept
            // 
            resources.ApplyResources(m_btAccept, "m_btAccept");
            m_btAccept.Name = "m_btAccept";
            m_btAccept.UseVisualStyleBackColor = true;
            m_btAccept.Click += buttonCreate_Click;
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
            textBoxInfo.ReadOnly = true;
            // 
            // m_listPlantTypeView
            // 
            resources.ApplyResources(m_listPlantTypeView, "m_listPlantTypeView");
            m_listPlantTypeView.Name = "m_listPlantTypeView";
            m_listPlantTypeView.UseCompatibleStateImageBehavior = false;
            m_listPlantTypeView.ItemCheck += m_listPlantTypeView_ItemCheck;
            m_listPlantTypeView.ItemChecked += m_listPlantTypeView_ItemChecked;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // textBoxPlantSearch
            // 
            resources.ApplyResources(textBoxPlantSearch, "textBoxPlantSearch");
            textBoxPlantSearch.Name = "textBoxPlantSearch";
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
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            resources.ApplyResources(splitContainer3.Panel2, "splitContainer3.Panel2");
            splitContainer3.Panel2.Controls.Add(textBox1);
            // 
            // splitContainer4
            // 
            resources.ApplyResources(splitContainer4, "splitContainer4");
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            resources.ApplyResources(splitContainer4.Panel1, "splitContainer4.Panel1");
            splitContainer4.Panel1.Controls.Add(listView1);
            // 
            // splitContainer4.Panel2
            // 
            resources.ApplyResources(splitContainer4.Panel2, "splitContainer4.Panel2");
            splitContainer4.Panel2.Controls.Add(button2);
            splitContainer4.Panel2.Controls.Add(button1);
            // 
            // listView1
            // 
            resources.ApplyResources(listView1, "listView1");
            listView1.Name = "listView1";
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(tabDefinePlanter);
            tabControl1.Controls.Add(tabPlantTypes);
            tabControl1.Controls.Add(tabMovePlants);
            tabControl1.Controls.Add(tabSuggestions);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.Selecting += tabControl1_Selecting;
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
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
            m_gBPlacement.ResumeLayout(false);
            m_gBPlacement.PerformLayout();
            m_gBSize.ResumeLayout(false);
            m_gBSize.PerformLayout();
            m_gBNutrition.ResumeLayout(false);
            m_gBNutrition.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem debugWindowToolStripMenuItem;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer7;
        private TextBox m_textName;
        private Button m_btAbort;
        private Label label1;
        private GroupBox m_gBPlacement;
        private RadioButton m_rBInside;
        private RadioButton m_rBOutside;
        private GroupBox m_gBSize;
        private TextBox m_textBoxWidth;
        private TextBox m_textBoxLength;
        private GroupBox m_gBNutrition;
        private RadioButton m_radioButtonHigh;
        private RadioButton m_radioButtonMedium;
        private RadioButton m_radioButtonLow;
        private Button m_btAccept;
        private GroupBox groupBox4;
        private TextBox textBoxInfo;
        private TextBox textBoxPlantSearch;
        private Label label2;
        private ListView listPlanters;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private ListView listView1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Button m_newButton;
        private Button m_deleteButton;
        private Label label5;
        private ListView m_listPlantTypeView;
    }
}