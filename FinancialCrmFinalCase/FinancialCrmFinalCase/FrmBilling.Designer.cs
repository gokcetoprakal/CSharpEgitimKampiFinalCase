namespace FinancialCrmFinalCase
{
    partial class FrmBilling
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBillDelete = new System.Windows.Forms.Button();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.btnBillUpdate = new System.Windows.Forms.Button();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.btnBillAdd = new System.Windows.Forms.Button();
            this.btnBillGetByID = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 52);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fatura İşlemleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(39)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnSpendings);
            this.panel1.Controls.Add(this.btnBills);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.Controls.Add(this.btnCategories);
            this.panel1.Location = new System.Drawing.Point(1, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 496);
            this.panel1.TabIndex = 7;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.Location = new System.Drawing.Point(3, 429);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(165, 37);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Çıkış Yap";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.Location = new System.Drawing.Point(3, 289);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(165, 37);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.Location = new System.Drawing.Point(3, 359);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(165, 37);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSpendings
            // 
            this.btnSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendings.Location = new System.Drawing.Point(3, 219);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(165, 37);
            this.btnSpendings.TabIndex = 3;
            this.btnSpendings.Text = "Gelir-Giderler";
            this.btnSpendings.UseVisualStyleBackColor = true;
            this.btnSpendings.Click += new System.EventHandler(this.btnSpendings_Click);
            // 
            // btnBills
            // 
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBills.Location = new System.Drawing.Point(3, 149);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(165, 37);
            this.btnBills.TabIndex = 2;
            this.btnBills.Text = "Faturalar";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.Location = new System.Drawing.Point(3, 79);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(165, 37);
            this.btnBanks.TabIndex = 1;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = true;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategories.Location = new System.Drawing.Point(3, 9);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(165, 37);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.UseVisualStyleBackColor = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnBillDelete);
            this.panel3.Controls.Add(this.txtBillPeriod);
            this.panel3.Controls.Add(this.txtBillAmount);
            this.panel3.Controls.Add(this.btnBillUpdate);
            this.panel3.Controls.Add(this.txtBillTitle);
            this.panel3.Controls.Add(this.txtBillID);
            this.panel3.Controls.Add(this.btnBillAdd);
            this.panel3.Controls.Add(this.btnBillGetByID);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(184, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 487);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Miktar:";
            // 
            // btnBillDelete
            // 
            this.btnBillDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillDelete.Location = new System.Drawing.Point(236, 383);
            this.btnBillDelete.Name = "btnBillDelete";
            this.btnBillDelete.Size = new System.Drawing.Size(136, 74);
            this.btnBillDelete.TabIndex = 11;
            this.btnBillDelete.Text = "Fatura Sil";
            this.btnBillDelete.UseVisualStyleBackColor = true;
            this.btnBillDelete.Click += new System.EventHandler(this.btnBillDelete_Click);
            // 
            // txtBillPeriod
            // 
            this.txtBillPeriod.Location = new System.Drawing.Point(104, 194);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(284, 22);
            this.txtBillPeriod.TabIndex = 7;
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.Location = new System.Drawing.Point(104, 134);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(284, 22);
            this.txtBillAmount.TabIndex = 6;
            // 
            // btnBillUpdate
            // 
            this.btnBillUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillUpdate.Location = new System.Drawing.Point(26, 383);
            this.btnBillUpdate.Name = "btnBillUpdate";
            this.btnBillUpdate.Size = new System.Drawing.Size(136, 74);
            this.btnBillUpdate.TabIndex = 10;
            this.btnBillUpdate.Text = "Fatura Güncelle";
            this.btnBillUpdate.UseVisualStyleBackColor = true;
            this.btnBillUpdate.Click += new System.EventHandler(this.btnBillUpdate_Click);
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.Location = new System.Drawing.Point(104, 74);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(284, 22);
            this.txtBillTitle.TabIndex = 5;
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(104, 14);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(284, 22);
            this.txtBillID.TabIndex = 4;
            // 
            // btnBillAdd
            // 
            this.btnBillAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillAdd.Location = new System.Drawing.Point(236, 263);
            this.btnBillAdd.Name = "btnBillAdd";
            this.btnBillAdd.Size = new System.Drawing.Size(136, 74);
            this.btnBillAdd.TabIndex = 9;
            this.btnBillAdd.Text = "Fatura Ekle";
            this.btnBillAdd.UseVisualStyleBackColor = true;
            this.btnBillAdd.Click += new System.EventHandler(this.btnBillAdd_Click);
            // 
            // btnBillGetByID
            // 
            this.btnBillGetByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillGetByID.Location = new System.Drawing.Point(26, 263);
            this.btnBillGetByID.Name = "btnBillGetByID";
            this.btnBillGetByID.Size = new System.Drawing.Size(136, 74);
            this.btnBillGetByID.TabIndex = 8;
            this.btnBillGetByID.Text = "ID\'ye Göre Fatura Görüntüle";
            this.btnBillGetByID.UseVisualStyleBackColor = true;
            this.btnBillGetByID.Click += new System.EventHandler(this.btnBillGetByID_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dönem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Başlık:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(31)))), ((int)(((byte)(151)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(578, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 487);
            this.dataGridView1.TabIndex = 10;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1085, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBilling";
            this.Text = "FrmBilling";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBillDelete;
        private System.Windows.Forms.Button btnBillUpdate;
        private System.Windows.Forms.Button btnBillAdd;
        private System.Windows.Forms.Button btnBillGetByID;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.Label label4;
    }
}