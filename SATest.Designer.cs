namespace GardenSolver
{
    partial class SATest
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
            outputBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // outputBox
            // 
            outputBox.Dock = DockStyle.Top;
            outputBox.Location = new Point(0, 0);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(1431, 716);
            outputBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(616, 722);
            button1.Name = "button1";
            button1.Size = new Size(202, 35);
            button1.TabIndex = 1;
            button1.Text = "Start solving";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SATest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 769);
            Controls.Add(button1);
            Controls.Add(outputBox);
            Name = "SATest";
            Text = "SATest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox outputBox;
        private Button button1;
    }
}