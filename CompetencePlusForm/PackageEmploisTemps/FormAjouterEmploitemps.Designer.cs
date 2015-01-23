namespace CompetencePlus.PackageEmploisTemps
{
    partial class FormAjouterEmploitemps
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btajouteremploitemps = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.anneeFormationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seanceplanningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btajouter = new System.Windows.Forms.Button();
            this.emploisTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Emploitemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heuredebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heurefinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anneeFormationBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceplanningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploisTempBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btajouteremploitemps);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emploistemps";
            // 
            // btajouteremploitemps
            // 
            this.btajouteremploitemps.Location = new System.Drawing.Point(142, 115);
            this.btajouteremploitemps.Name = "btajouteremploitemps";
            this.btajouteremploitemps.Size = new System.Drawing.Size(86, 23);
            this.btajouteremploitemps.TabIndex = 3;
            this.btajouteremploitemps.Text = "Ajouter";
            this.btajouteremploitemps.UseVisualStyleBackColor = true;
            this.btajouteremploitemps.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(142, 89);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.anneeFormationBindingSource;
            this.comboBox1.DisplayMember = "Titre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Id";
            // 
            // anneeFormationBindingSource
            // 
            this.anneeFormationBindingSource.DataSource = typeof(CompetencePlus.PackageAnneeFormations.AnneeFormation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Début :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Années de Formation :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Séances";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emploitemp,
            this.jourDataGridViewTextBoxColumn,
            this.heuredebutDataGridViewTextBoxColumn,
            this.heurefinDataGridViewTextBoxColumn,
            this.formationDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.DataSource = this.seanceplanningBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 176);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // seanceplanningBindingSource
            // 
            this.seanceplanningBindingSource.DataSource = typeof(CompetencePlus.PackageEmploisTemps.Seanceplanning);
            // 
            // btajouter
            // 
            this.btajouter.Location = new System.Drawing.Point(545, 144);
            this.btajouter.Name = "btajouter";
            this.btajouter.Size = new System.Drawing.Size(101, 23);
            this.btajouter.TabIndex = 2;
            this.btajouter.Text = "Ajouter";
            this.btajouter.UseVisualStyleBackColor = true;
            this.btajouter.Click += new System.EventHandler(this.btajouter_Click);
            // 
            // emploisTempBindingSource
            // 
            this.emploisTempBindingSource.DataSource = typeof(CompetencePlus.PackageEmploisTemps.EmploisTemp);
            // 
            // Emploitemp
            // 
            this.Emploitemp.DataPropertyName = "Emploitemp";
            this.Emploitemp.HeaderText = "Emploitemp";
            this.Emploitemp.Name = "Emploitemp";
            // 
            // jourDataGridViewTextBoxColumn
            // 
            this.jourDataGridViewTextBoxColumn.DataPropertyName = "Jour";
            this.jourDataGridViewTextBoxColumn.HeaderText = "Jour";
            this.jourDataGridViewTextBoxColumn.Name = "jourDataGridViewTextBoxColumn";
            // 
            // heuredebutDataGridViewTextBoxColumn
            // 
            this.heuredebutDataGridViewTextBoxColumn.DataPropertyName = "Heuredebut";
            this.heuredebutDataGridViewTextBoxColumn.HeaderText = "Heuredebut";
            this.heuredebutDataGridViewTextBoxColumn.Name = "heuredebutDataGridViewTextBoxColumn";
            this.heuredebutDataGridViewTextBoxColumn.Width = 90;
            // 
            // heurefinDataGridViewTextBoxColumn
            // 
            this.heurefinDataGridViewTextBoxColumn.DataPropertyName = "Heurefin";
            this.heurefinDataGridViewTextBoxColumn.HeaderText = "Heurefin";
            this.heurefinDataGridViewTextBoxColumn.Name = "heurefinDataGridViewTextBoxColumn";
            this.heurefinDataGridViewTextBoxColumn.Width = 90;
            // 
            // formationDataGridViewTextBoxColumn
            // 
            this.formationDataGridViewTextBoxColumn.DataPropertyName = "Formation";
            this.formationDataGridViewTextBoxColumn.HeaderText = "Formation";
            this.formationDataGridViewTextBoxColumn.Name = "formationDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Modifier";
            this.Column1.Image = global::CompetencePlus.Properties.Resources.Update;
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Supprimer";
            this.Column2.Image = global::CompetencePlus.Properties.Resources.Delete;
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Id";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // FormAjouterEmploitemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 399);
            this.Controls.Add(this.btajouter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAjouterEmploitemps";
            this.Text = "FormAjouterEmploitemps";
            this.Load += new System.EventHandler(this.FormAjouterEmploitemps_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anneeFormationBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seanceplanningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploisTempBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource seanceplanningBindingSource;
        private System.Windows.Forms.Button btajouter;
        private System.Windows.Forms.BindingSource anneeFormationBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btajouteremploitemps;
        private System.Windows.Forms.BindingSource emploisTempBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emploitemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn jourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuredebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heurefinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}