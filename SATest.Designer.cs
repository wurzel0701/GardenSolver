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
            SuspendLayout();
            // 
            // outputBox
            // 
            outputBox.Dock = DockStyle.Fill;
            outputBox.Location = new Point(0, 0);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(800, 450);
            outputBox.TabIndex = 0;
            // 
            // SATest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputBox);
            Name = "SATest";
            Text = "SATest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox outputBox;
    }
}