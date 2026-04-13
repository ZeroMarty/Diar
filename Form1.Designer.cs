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
            this.components = new System.ComponentModel.Container();
            this.btn_Pridej = new System.Windows.Forms.Button();
            this.btn_Upravit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cislo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.udalosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dulezitost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.al = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pridej
            // 
            this.btn_Pridej.Location = new System.Drawing.Point(218, 396);
            this.btn_Pridej.Name = "btn_Pridej";
            this.btn_Pridej.Size = new System.Drawing.Size(101, 42);
            this.btn_Pridej.TabIndex = 0;
            this.btn_Pridej.Text = "Nová událost";
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cislo,
            this.udalosts,
            this.interval,
            this.dulezitost,
            this.datum,
            this.al});
            this.dataGridView1.Location = new System.Drawing.Point(60, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 299);
            this.dataGridView1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cislo
            // 
            this.cislo.DataPropertyName = "id";
            this.cislo.HeaderText = "Id";
            this.cislo.Name = "cislo";
            // 
            // udalosts
            // 
            this.udalosts.DataPropertyName = "nazev";
            this.udalosts.HeaderText = "Událost";
            this.udalosts.Name = "udalosts";
            // 
            // interval
            // 
            this.interval.DataPropertyName = "interval";
            this.interval.HeaderText = "Doba";
            this.interval.Name = "interval";
            // 
            // dulezitost
            // 
            this.dulezitost.DataPropertyName = "dulezitost";
            this.dulezitost.HeaderText = "Důležitost";
            this.dulezitost.Name = "dulezitost";
            // 
            // datum
            // 
            this.datum.DataPropertyName = "datum";
            this.datum.HeaderText = "Datum";
            this.datum.Name = "datum";
            // 
            // al
            // 
            this.al.DataPropertyName = "alarm";
            this.al.HeaderText = "Alarm";
            this.al.Name = "al";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cislo;
        private System.Windows.Forms.DataGridViewTextBoxColumn udalosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn dulezitost;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn al;
    }
}

