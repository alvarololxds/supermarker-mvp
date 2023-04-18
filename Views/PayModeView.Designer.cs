namespace Supermarket.mvp.Views
{
    partial class PayModeView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePayModeDetail = new System.Windows.Forms.TabPage();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgPayMode = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.TabPage();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtPayModeObservation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPayModeName = new System.Windows.Forms.TextBox();
            this.TxtPayModeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePayModeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).BeginInit();
            this.s.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Supermarket.mvp.Properties.Resources.buy;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay Mode";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePayModeDetail);
            this.tabControl1.Controls.Add(this.s);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 350);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeDetail
            // 
            this.tabPagePayModeDetail.Controls.Add(this.BtnClose);
            this.tabPagePayModeDetail.Controls.Add(this.BtnDelete);
            this.tabPagePayModeDetail.Controls.Add(this.BtnEdit);
            this.tabPagePayModeDetail.Controls.Add(this.BtnNew);
            this.tabPagePayModeDetail.Controls.Add(this.DgPayMode);
            this.tabPagePayModeDetail.Controls.Add(this.BtnSearch);
            this.tabPagePayModeDetail.Controls.Add(this.TxtSearch);
            this.tabPagePayModeDetail.Controls.Add(this.label2);
            this.tabPagePayModeDetail.Location = new System.Drawing.Point(4, 24);
            this.tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            this.tabPagePayModeDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayModeDetail.Size = new System.Drawing.Size(792, 322);
            this.tabPagePayModeDetail.TabIndex = 0;
            this.tabPagePayModeDetail.Text = "Paymodelist";
            this.tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::Supermarket.mvp.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(681, 248);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(57, 55);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Image = global::Supermarket.mvp.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(681, 177);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(57, 55);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Supermarket.mvp.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(681, 116);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(57, 55);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::Supermarket.mvp.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(681, 45);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(57, 55);
            this.BtnNew.TabIndex = 4;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            this.DgPayMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPayMode.Location = new System.Drawing.Point(8, 61);
            this.DgPayMode.Name = "DgPayMode";
            this.DgPayMode.RowTemplate.Height = 25;
            this.DgPayMode.Size = new System.Drawing.Size(454, 253);
            this.DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = global::Supermarket.mvp.Properties.Resources.search;
            this.BtnSearch.Location = new System.Drawing.Point(474, 14);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(54, 44);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(7, 32);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PlaceholderText = "Data to search";
            this.TxtSearch.Size = new System.Drawing.Size(455, 23);
            this.TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search Pay Mode";
            // 
            // s
            // 
            this.s.Controls.Add(this.BtnCancel);
            this.s.Controls.Add(this.BtnSave);
            this.s.Controls.Add(this.TxtPayModeObservation);
            this.s.Controls.Add(this.label5);
            this.s.Controls.Add(this.label4);
            this.s.Controls.Add(this.TxtPayModeName);
            this.s.Controls.Add(this.TxtPayModeId);
            this.s.Controls.Add(this.label3);
            this.s.Location = new System.Drawing.Point(4, 24);
            this.s.Name = "s";
            this.s.Padding = new System.Windows.Forms.Padding(3);
            this.s.Size = new System.Drawing.Size(792, 322);
            this.s.TabIndex = 1;
            this.s.Text = "PayModeDetail";
            this.s.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = global::Supermarket.mvp.Properties.Resources.cancel;
            this.BtnCancel.Location = new System.Drawing.Point(170, 254);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 60);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Supermarket.mvp.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(42, 254);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 60);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            this.TxtPayModeObservation.Location = new System.Drawing.Point(26, 186);
            this.TxtPayModeObservation.Multiline = true;
            this.TxtPayModeObservation.Name = "TxtPayModeObservation";
            this.TxtPayModeObservation.Size = new System.Drawing.Size(241, 62);
            this.TxtPayModeObservation.TabIndex = 5;
            this.TxtPayModeObservation.Text = "Pay Mode Observation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pay Mode Observation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeName
            // 
            this.TxtPayModeName.Location = new System.Drawing.Point(26, 109);
            this.TxtPayModeName.Name = "TxtPayModeName";
            this.TxtPayModeName.Size = new System.Drawing.Size(241, 23);
            this.TxtPayModeName.TabIndex = 2;
            this.TxtPayModeName.Text = "Pay Mode Name";
            // 
            // TxtPayModeId
            // 
            this.TxtPayModeId.Location = new System.Drawing.Point(26, 41);
            this.TxtPayModeId.Name = "TxtPayModeId";
            this.TxtPayModeId.Size = new System.Drawing.Size(100, 23);
            this.TxtPayModeId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pay Mode Id";
            // 
            // PayModeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "PayModeView";
            this.Text = "PayModeView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePayModeDetail.ResumeLayout(false);
            this.tabPagePayModeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgPayMode)).EndInit();
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private TabPage s;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private Label label4;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Label label3;
    }
}