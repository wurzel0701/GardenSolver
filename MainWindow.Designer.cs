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
            treeView1 = new TreeView();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            createButton = new Button();
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
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabDefinePlanter.SuspendLayout();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(splitContainer1.Panel2, "splitContainer1.Panel2");
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(createButton);
            // 
            // treeView1
            // 
            resources.ApplyResources(treeView1, "treeView1");
            treeView1.Name = "treeView1";
            treeView1.Nodes.AddRange(new TreeNode[] { (TreeNode)resources.GetObject("treeView1.Nodes"), (TreeNode)resources.GetObject("treeView1.Nodes1") });
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.Checked = true;
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // createButton
            // 
            resources.ApplyResources(createButton, "createButton");
            createButton.Name = "createButton";
            createButton.UseVisualStyleBackColor = true;
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
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.Name = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            resources.ApplyResources(radioButton3, "radioButton3");
            radioButton3.Name = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(radioButton8);
            groupBox3.Controls.Add(radioButton9);
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
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
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(textBox2, "textBox2");
            textBox2.Name = "textBox2";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabDefinePlanter.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private TreeView treeView1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private Button createButton;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private GroupBox groupBox3;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}