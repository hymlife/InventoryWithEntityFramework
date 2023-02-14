namespace InventoryWithEntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblHardwareNo = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblFaultStatus = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBoxHardwareNo = new System.Windows.Forms.TextBox();
            this.txtBoxBrand = new System.Windows.Forms.TextBox();
            this.txtBoxModel = new System.Windows.Forms.TextBox();
            this.txtBoxSerialNo = new System.Windows.Forms.TextBox();
            this.txtBoxFaultStatus = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(667, 405);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lblHardwareNo
            // 
            this.lblHardwareNo.AutoSize = true;
            this.lblHardwareNo.Location = new System.Drawing.Point(751, 35);
            this.lblHardwareNo.Name = "lblHardwareNo";
            this.lblHardwareNo.Size = new System.Drawing.Size(77, 15);
            this.lblHardwareNo.TabIndex = 1;
            this.lblHardwareNo.Text = "Hardware No";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(751, 95);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 15);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(751, 153);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(41, 15);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(751, 214);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(54, 15);
            this.lblSerialNo.TabIndex = 4;
            this.lblSerialNo.Text = "Serial No";
            // 
            // lblFaultStatus
            // 
            this.lblFaultStatus.AutoSize = true;
            this.lblFaultStatus.Location = new System.Drawing.Point(751, 272);
            this.lblFaultStatus.Name = "lblFaultStatus";
            this.lblFaultStatus.Size = new System.Drawing.Size(68, 15);
            this.lblFaultStatus.TabIndex = 5;
            this.lblFaultStatus.Text = "Fault Status";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(751, 326);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // txtBoxHardwareNo
            // 
            this.txtBoxHardwareNo.Location = new System.Drawing.Point(751, 53);
            this.txtBoxHardwareNo.Name = "txtBoxHardwareNo";
            this.txtBoxHardwareNo.Size = new System.Drawing.Size(147, 23);
            this.txtBoxHardwareNo.TabIndex = 7;
            // 
            // txtBoxBrand
            // 
            this.txtBoxBrand.Location = new System.Drawing.Point(751, 113);
            this.txtBoxBrand.Name = "txtBoxBrand";
            this.txtBoxBrand.Size = new System.Drawing.Size(147, 23);
            this.txtBoxBrand.TabIndex = 8;
            // 
            // txtBoxModel
            // 
            this.txtBoxModel.Location = new System.Drawing.Point(751, 171);
            this.txtBoxModel.Name = "txtBoxModel";
            this.txtBoxModel.Size = new System.Drawing.Size(147, 23);
            this.txtBoxModel.TabIndex = 9;
            // 
            // txtBoxSerialNo
            // 
            this.txtBoxSerialNo.Location = new System.Drawing.Point(751, 232);
            this.txtBoxSerialNo.Name = "txtBoxSerialNo";
            this.txtBoxSerialNo.Size = new System.Drawing.Size(147, 23);
            this.txtBoxSerialNo.TabIndex = 10;
            // 
            // txtBoxFaultStatus
            // 
            this.txtBoxFaultStatus.Location = new System.Drawing.Point(751, 290);
            this.txtBoxFaultStatus.Name = "txtBoxFaultStatus";
            this.txtBoxFaultStatus.Size = new System.Drawing.Size(147, 23);
            this.txtBoxFaultStatus.TabIndex = 11;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(751, 344);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(147, 23);
            this.txtBoxDate.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(728, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSave.Location = new System.Drawing.Point(836, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClear.Location = new System.Drawing.Point(594, 446);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 32);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 534);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.txtBoxFaultStatus);
            this.Controls.Add(this.txtBoxSerialNo);
            this.Controls.Add(this.txtBoxModel);
            this.Controls.Add(this.txtBoxBrand);
            this.Controls.Add(this.txtBoxHardwareNo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblFaultStatus);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblHardwareNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblHardwareNo;
        private Label lblBrand;
        private Label lblModel;
        private Label lblSerialNo;
        private Label lblFaultStatus;
        private Label lblDate;
        private TextBox txtBoxHardwareNo;
        private TextBox txtBoxBrand;
        private TextBox txtBoxModel;
        private TextBox txtBoxSerialNo;
        private TextBox txtBoxFaultStatus;
        private TextBox txtBoxDate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnClear;
    }
}