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
    public partial class FormAjouterEmploitemps : Form
    {
        public FormAjouterEmploitemps()
        {
            InitializeComponent();
            btajouter.Enabled = false;
        }

        public void refresh()
        {
            seanceplanningBindingSource.DataSource = null;
          
           // seanceplanningBindingSource.DataSource = new SeanceplanningDAO().Select(new SeanceplanningDAO().Lastnumber());
           seanceplanningBindingSource.DataSource = new SeanceplanningDAO().FindById(int.Parse(dataGridView1.SelectedRows[0].Cells["Column3"].Value.ToString())); // ?nred lwla ? !! att nchof 
        
            

        }
        public static List<Seanceplanning> liste = new List<Seanceplanning>();
        private void btajouter_Click(object sender, EventArgs e)
        {
        
                formSeancePlanning s = new formSeancePlanning();
                s.ShowDialog();
               // this.refresh();

                MessageBox.Show(new SeanceplanningDAO().Lastnumber().ToString());
        
            seanceplanningBindingSource.DataSource = null;
        seanceplanningBindingSource.DataSource =  SeanceplanningDAO.Select(new SeanceplanningDAO().Lastnumber());
           // seanceplanningBindingSource.DataSource = new SeanceplanningDAO().FindById(int.Parse(dataGridView1.SelectedRows[0].Cells["Column3"].Value.ToString()));  
              
          
        }
       
        int id;
        public EmploisTemp update()
        {

            EmploisTemp emploi =(EmploisTemp)emploisTempBindingSource.Current;
            this.id = emploi.Id;
            return emploi;
        }
        private void FormAjouterEmploitemps_Load(object sender, EventArgs e)
        {
           
           
            anneeFormationBindingSource.DataSource = null;
            anneeFormationBindingSource.DataSource = new PackageAnneeFormations.AnneformationDAO().select();
           // this.refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Seanceplanning s = (Seanceplanning)seanceplanningBindingSource.Current;
               
                if (e.ColumnIndex == 4)
                {
                   FormUpdateSeancePlanning f = new FormUpdateSeancePlanning();
                   f.update(s);
                    f.ShowDialog();
                    this.refresh();
                }
                if (e.ColumnIndex == 5 && MessageBox.Show("voulez vous supprimer cet seance", "Information dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new SeanceplanningDAO().Delete(s.Id);
                    this.refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Seanceplanning s = (Seanceplanning)seanceplanningBindingSource.Current;

                if (e.ColumnIndex == 5)
                {
                    FormUpdateSeancePlanning f = new FormUpdateSeancePlanning();
                    f.update(s);
                   f.ShowDialog();
                    this.refresh();
                }
                if (e.ColumnIndex == 6 && MessageBox.Show("voulez vous supprimer cet seance", "Information dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new SeanceplanningDAO().Delete(s.Id);
                    this.refresh();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
           

            EmploisTemp c = new EmploisTemp();
            c.Id = 1;
            c.Anneeformation = (PackageAnneeFormations.AnneeFormation)anneeFormationBindingSource.Current;
            c.DateDebut = dateTimePicker1.Value;
            c.DateFin = dateTimePicker2.Value;
            new EmploisTempDAO().Add(c);
           btajouter.Enabled = true;
           btajouteremploitemps.Enabled = false;
        }
    }
}
