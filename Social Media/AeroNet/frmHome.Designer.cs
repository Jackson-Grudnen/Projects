namespace AeroNet
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 62, 23);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 638);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.aeronetlogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 118);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.penicon;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(1058, 534);
            button1.Name = "button1";
            button1.Size = new Size(94, 85);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 631);
            Controls.Add(button1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHome";
            Text = "Home";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}