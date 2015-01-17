namespace CompetencePlus.PackageEmploisTemps
{
    partial class FormUpdateSeancePlanning
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
            this.userControltime2 = new CompetencePlus.UserControltime();
            this.userControltime1 = new CompetencePlus.UserControltime();
            this.FormationcomboBox = new System.Windows.Forms.ComboBox();
            this.formationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btannuler = new System.Windows.Forms.Button();
            this.btenregistrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dimancheradio = new System.Windows.Forms.RadioButton();
            this.samediradio = new System.Windows.Forms.RadioButton();
            this.vendrediradio = new System.Windows.Forms.RadioButton();
            this.jeudiradio = new System.Windows.Forms.RadioButton();
            this.mercrediradio = new System.Windows.Forms.RadioButton();
            this.mardiradio = new System.Windows.Forms.RadioButton();
            this.Lundiradio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userControltime2
            // 
            this.userControltime2.Hm = "0:0";
            this.userControltime2.Hour = null;
            this.userControltime2.Location = new System.Drawing.Point(251, 142);
            this.userControltime2.Min = null;
            this.userControltime2.Name = "userControltime2";
            this.userControltime2.Size = new System.Drawing.Size(179, 69);
            this.userControltime2.TabIndex = 11;
            // 
            // userControltime1
            // 
            this.userControltime1.Hm = "0:0";
            this.userControltime1.Hour = null;
            this.userControltime1.Location = new System.Drawing.Point(251, 71);
            this.userControltime1.Min = null;
            this.userControltime1.Name = "userControltime1";
            this.userControltime1.Size = new System.Drawing.Size(179, 69);
            this.userControltime1.TabIndex = 10;
            // 
            // FormationcomboBox
            // 
            this.FormationcomboBox.DataSource = this.formationBindingSource;
            this.FormationcomboBox.DisplayMember = "Code";
            this.FormationcomboBox.FormattingEnabled = true;
            this.FormationcomboBox.Location = new System.Drawing.Point(251, 44);
            this.FormationcomboBox.Name = "FormationcomboBox";
            this.FormationcomboBox.Size = new System.Drawing.Size(215, 21);
            this.FormationcomboBox.TabIndex = 7;
            this.FormationcomboBox.ValueMember = "Id";
            // 
            // formationBindingSource
            // 
            this.formationBindingSource.DataSource = typeof(CompetencePlus.PackageFormations.Formation);
            // 
            // btannuler
            // 
            this.btannuler.Location = new System.Drawing.Point(346, 238);
            this.btannuler.Name = "btannuler";
            this.btannuler.Size = new System.Drawing.Size(84, 23);
            this.btannuler.TabIndex = 6;
            this.btannuler.Text = "Annuler";
            this.btannuler.UseVisualStyleBackColor = true;
            this.btannuler.Click += new System.EventHandler(this.btannuler_Click);
            // 
            // btenregistrer
            // 
            this.btenregistrer.Location = new System.Drawing.Point(251, 238);
            this.btenregistrer.Name = "btenregistrer";
            this.btenregistrer.Size = new System.Drawing.Size(84, 23);
            this.btenregistrer.TabIndex = 5;
            this.btenregistrer.Text = "Enregistrer";
            this.btenregistrer.UseVisualStyleBackColor = true;
            this.btenregistrer.Click += new System.EventHandler(this.btenregistrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Heure Fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Heure Début :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formation : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dimancheradio);
            this.groupBox1.Controls.Add(this.samediradio);
            this.groupBox1.Controls.Add(this.vendrediradio);
            this.groupBox1.Controls.Add(this.jeudiradio);
            this.groupBox1.Controls.Add(this.mercrediradio);
            this.groupBox1.Controls.Add(this.mardiradio);
            this.groupBox1.Controls.Add(this.Lundiradio);
            this.groupBox1.Location = new System.Drawing.Point(16, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jour";
            // 
            // dimancheradio
            // 
            this.dimancheradio.AutoSize = true;
            this.dimancheradio.Location = new System.Drawing.Point(15, 221);
            this.dimancheradio.Name = "dimancheradio";
            this.dimancheradio.Size = new System.Drawing.Size(73, 17);
            this.dimancheradio.TabIndex = 15;
            this.dimancheradio.TabStop = true;
            this.dimancheradio.Text = "Dimanche";
            this.dimancheradio.UseVisualStyleBackColor = true;
            // 
            // samediradio
            // 
            this.samediradio.AutoSize = true;
            this.samediradio.Location = new System.Drawing.Point(15, 188);
            this.samediradio.Name = "samediradio";
            this.samediradio.Size = new System.Drawing.Size(60, 17);
            this.samediradio.TabIndex = 14;
            this.samediradio.TabStop = true;
            this.samediradio.Text = "Samedi";
            this.samediradio.UseVisualStyleBackColor = true;
            // 
            // vendrediradio
            // 
            this.vendrediradio.AutoSize = true;
            this.vendrediradio.Location = new System.Drawing.Point(15, 152);
            this.vendrediradio.Name = "vendrediradio";
            this.vendrediradio.Size = new System.Drawing.Size(67, 17);
            this.vendrediradio.TabIndex = 13;
            this.vendrediradio.TabStop = true;
            this.vendrediradio.Text = "Vendredi";
            this.vendrediradio.UseVisualStyleBackColor = true;
            // 
            // jeudiradio
            // 
            this.jeudiradio.AutoSize = true;
            this.jeudiradio.Location = new System.Drawing.Point(15, 117);
            this.jeudiradio.Name = "jeudiradio";
            this.jeudiradio.Size = new System.Drawing.Size(50, 17);
            this.jeudiradio.TabIndex = 12;
            this.jeudiradio.TabStop = true;
            this.jeudiradio.Text = "Jeudi";
            this.jeudiradio.UseVisualStyleBackColor = true;
            // 
            // mercrediradio
            // 
            this.mercrediradio.AutoSize = true;
            this.mercrediradio.Location = new System.Drawing.Point(15, 83);
            this.mercrediradio.Name = "mercrediradio";
            this.mercrediradio.Size = new System.Drawing.Size(66, 17);
            this.mercrediradio.TabIndex = 11;
            this.mercrediradio.TabStop = true;
            this.mercrediradio.Text = "Mercredi";
            this.mercrediradio.UseVisualStyleBackColor = true;
            // 
            // mardiradio
            // 
            this.mardiradio.AutoSize = true;
            this.mardiradio.Location = new System.Drawing.Point(15, 51);
            this.mardiradio.Name = "mardiradio";
            this.mardiradio.Size = new System.Drawing.Size(51, 17);
            this.mardiradio.TabIndex = 10;
            this.mardiradio.TabStop = true;
            this.mardiradio.Text = "Mardi";
            this.mardiradio.UseVisualStyleBackColor = true;
            // 
            // Lundiradio
            // 
            this.Lundiradio.AutoSize = true;
            this.Lundiradio.Location = new System.Drawing.Point(15, 19);
            this.Lundiradio.Name = "Lundiradio";
            this.Lundiradio.Size = new System.Drawing.Size(51, 17);
            this.Lundiradio.TabIndex = 9;
            this.Lundiradio.TabStop = true;
            this.Lundiradio.Text = "Lundi";
            this.Lundiradio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userControltime2);
            this.groupBox2.Controls.Add(this.userControltime1);
            this.groupBox2.Controls.Add(this.FormationcomboBox);
            this.groupBox2.Controls.Add(this.btannuler);
            this.groupBox2.Controls.Add(this.btenregistrer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(31, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 309);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SeancePlanning";
            // 
            // FormUpdateSeancePlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 376);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormUpdateSeancePlanning";
            this.Text = "FormUpdateSeancePlanning";
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControltime userControltime2;
        private UserControltime userControltime1;
        private System.Windows.Forms.ComboBox FormationcomboBox;
        private System.Windows.Forms.Button btannuler;
        private System.Windows.Forms.Button btenregistrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dimancheradio;
        private System.Windows.Forms.RadioButton samediradio;
        private System.Windows.Forms.RadioButton vendrediradio;
        private System.Windows.Forms.RadioButton jeudiradio;
        private System.Windows.Forms.RadioButton mercrediradio;
        private System.Windows.Forms.RadioButton mardiradio;
        private System.Windows.Forms.RadioButton Lundiradio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource formationBindingSource;
    }
}