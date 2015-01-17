using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetencePlus.PackageEmploisTemps
{
    public partial class Form_gestion_des_emplois_temps : Form
    {
        public Form_gestion_des_emplois_temps()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            emploisTempBindingSource.DataSource = null;
            emploisTempBindingSource.DataSource = new EmploisTempDAO().Select();

        }

        private void btajouter_Click(object sender, EventArgs e)
        {
            FormAjouterEmploitemps f = new FormAjouterEmploitemps();
            f.Show();
            
           
        }

        private void Form_gestion_des_emplois_temps_Load(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EmploisTemp d = (EmploisTemp)emploisTempBindingSource.Current;

                if (e.ColumnIndex == 3)
                {
                   // FormUpdateSeancePlanning f = new FormUpdateSeancePlanning();
                   // f.update(d);
                   //f.ShowDialog();
                    this.refresh();
                }
                if (e.ColumnIndex == 4 && MessageBox.Show("voulez vous supprimer ce emploide temps", "Information dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new EmploisTempDAO().Delete(d.Id);
                    this.refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        }
    }

