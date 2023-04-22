namespace Supermarket.mvp.Views
{
    partial class MainView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPayMode = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket.mvp.Properties.Resources.sell;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnPayMode);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
            // 
            // BtnPayMode
            // 
            this.BtnPayMode.BackgroundImage = global::Supermarket.mvp.Properties.Resources.buy;
            this.BtnPayMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPayMode.Location = new System.Drawing.Point(12, 69);
            this.BtnPayMode.Name = "BtnPayMode";
            this.BtnPayMode.Size = new System.Drawing.Size(173, 74);
            this.BtnPayMode.TabIndex = 3;
            this.BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.BackgroundImage = global::Supermarket.mvp.Properties.Resources.cerrar;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.Location = new System.Drawing.Point(12, 315);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(173, 65);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "Supermarket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button BtnPayMode;
        private Button button1;
        private Button BtnExit;
    }
}