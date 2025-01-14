namespace GardenSolver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
        private System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1.Click += new(Button1_Click);
            this.button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button1.Location = new Point(200,0);
            this.button1.Size = new Size(80, 30);
            this.button1.Text = "Solve";
            this.button1.Name = "Solve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.TabIndex = 0;
            this.button1.Visible = true;

            this.button2.Click += new(Button2_Click);
            this.button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.button2.Location = new Point(200, 50);
            this.button2.Size = new Size(80, 30);
            this.button2.Text = "Reset";
            this.button2.Name = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.TabIndex = 0;
            this.button2.Visible = true;


            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            PerformLayout();
        }


        #endregion
    }
}
