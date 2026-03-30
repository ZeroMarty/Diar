namespace Diar
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Pridej = new System.Windows.Forms.Button();
            this.btn_Upravit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Udalost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duležitost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Upozorneni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pridej
            // 
            this.btn_Pridej.Location = new System.Drawing.Point(218, 396);
            this.btn_Pridej.Name = "btn_Pridej";
            this.btn_Pridej.Size = new System.Drawing.Size(101, 42);
            this.btn_Pridej.TabIndex = 0;
            this.btn_Pridej.Text = "Přidat";
            this.btn_Pridej.UseVisualStyleBackColor = true;
            this.btn_Pridej.Click += new System.EventHandler(this.btn_Pridej_Click);
            // 
            // btn_Upravit
            // 
            this.btn_Upravit.Location = new System.Drawing.Point(325, 396);
            this.btn_Upravit.Name = "btn_Upravit";
            this.btn_Upravit.Size = new System.Drawing.Size(101, 42);
            this.btn_Upravit.TabIndex = 1;
            this.btn_Upravit.Text = "Upravit";
            this.btn_Upravit.UseVisualStyleBackColor = true;
            this.btn_Upravit.Click += new System.EventHandler(this.btn_Upravit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(432, 396);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Delete.Size = new System.Drawing.Size(101, 42);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Smazat";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Udalost,
            this.Doba,
            this.Duležitost,
            this.Cas,
            this.Upozorneni});
            this.dataGridView1.Location = new System.Drawing.Point(60, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 299);
            this.dataGridView1.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Udalost
            // 
            this.Udalost.HeaderText = "Událost";
            this.Udalost.Name = "Udalost";
            // 
            // Doba
            // 
            this.Doba.HeaderText = "Doba";
            this.Doba.Name = "Doba";
            // 
            // Duležitost
            // 
            this.Duležitost.HeaderText = "Důležitost";
            this.Duležitost.Name = "Duležitost";
            // 
            // Cas
            // 
            this.Cas.HeaderText = "Čas";
            this.Cas.Name = "Cas";
            // 
            // Upozorneni
            // 
            this.Upozorneni.HeaderText = "Upozornění";
            this.Upozorneni.Name = "Upozorneni";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Upravit);
            this.Controls.Add(this.btn_Pridej);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Pridej;
        private System.Windows.Forms.Button btn_Upravit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Udalost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duležitost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Upozorneni;
    }
}

