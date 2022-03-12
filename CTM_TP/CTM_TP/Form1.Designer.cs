namespace CTM_TP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.heureDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDarrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDarrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTrajet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lists des Trajets";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisire la ville d\'arriver : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choisire la ville de dipart : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(438, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(438, 211);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(272, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Afficher Trajets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heureDepart,
            this.villeDepart,
            this.heureDarrivee,
            this.villeDarrivee,
            this.prixTrajet});
            this.dataGridView1.Location = new System.Drawing.Point(73, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // heureDepart
            // 
            this.heureDepart.HeaderText = "heureDepart";
            this.heureDepart.MinimumWidth = 6;
            this.heureDepart.Name = "heureDepart";
            this.heureDepart.Width = 125;
            // 
            // villeDepart
            // 
            this.villeDepart.HeaderText = "villeDepart";
            this.villeDepart.MinimumWidth = 6;
            this.villeDepart.Name = "villeDepart";
            this.villeDepart.Width = 125;
            // 
            // heureDarrivee
            // 
            this.heureDarrivee.HeaderText = "heureDarrivee";
            this.heureDarrivee.MinimumWidth = 6;
            this.heureDarrivee.Name = "heureDarrivee";
            this.heureDarrivee.Width = 125;
            // 
            // villeDarrivee
            // 
            this.villeDarrivee.HeaderText = "villeDarrivee";
            this.villeDarrivee.MinimumWidth = 6;
            this.villeDarrivee.Name = "villeDarrivee";
            this.villeDarrivee.Width = 125;
            // 
            // prixTrajet
            // 
            this.prixTrajet.HeaderText = "prixTrajet";
            this.prixTrajet.MinimumWidth = 6;
            this.prixTrajet.Name = "prixTrajet";
            this.prixTrajet.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDarrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDarrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTrajet;
    }
}

