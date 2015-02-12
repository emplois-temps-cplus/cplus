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
        
     
        public  int emploitempid;
    
        public int Emploitempid
        {
            get {
                EmploisTemp d = (EmploisTemp)emploisTempBindingSource.Current;
                return emploitempid=d.Id;
                }
            set { emploitempid = value; }
        }
       
        public void refresh()
        {
            emploisTempBindingSource.DataSource = null;
            emploisTempBindingSource.DataSource = new EmploisTempDAO().Select();

            try
            {

                foreach (DataGridViewRow ss in dataGridView1.Rows)
                {
                    //MessageBox.Show(ss.Cells[0].Value.ToString());
                    comboBox2.Items.Add(ss.Cells[0].Value.ToString());
                    comboBox3.Items.Add(ss.Cells[1].Value.ToString());

                }
                //foreach (DataGridViewRow ss in dataGridView1.Rows)
                //{
                //    //MessageBox.Show(ss.Cells[0].Value.ToString());
                //    comboBox3.Items.Add(ss.Cells[0].Value.ToString());
                //    // comboBox3.Items.Add(ss.Cells[1].Value.ToString());

                //}
            }
            catch
            {

            }
        }

   

        private void btajouter_Click(object sender, EventArgs e)
        {
            FormAjouterEmploitemps f = new FormAjouterEmploitemps();
            f.ismodfi(0);
            f.Ff = this;
            f.Show();
            
           
        }

        private void Form_gestion_des_emplois_temps_Load(object sender, EventArgs e)
        {
         

            anneeFormationBindingSource.DataSource = null;

            anneeFormationBindingSource.DataSource = new PackageAnneeFormations.AnneformationDAO().select();
            this.refresh();

           
          

        }

       

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EmploisTemp d = (EmploisTemp)emploisTempBindingSource.Current;
                
              
                if (e.ColumnIndex == 3)
                {
                   // int a = Emploitempid;
                emploitempid =  d.Id;
                   // MessageBox.Show(a.ToString());
                   MessageBox.Show(emploitempid.ToString());
                   // FormUpdateSeancePlanning f = new FormUpdateSeancePlanning();
                   // f.update(d); ama form ajouter emploi temps hiya li atle3 emploi temp fhmti? we we fhmtk daba nta bari dir ajouter o modifier f nafs buttonµ? hhh ana hit hadi jatni sahla atkon fhmti katkhdem f ajouter o katmchi l modifier we ok
                    //f.ShowDialog();  this.refresh();
                    FormAjouterEmploitemps f = new FormAjouterEmploitemps();
                  //int idemploit = int.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
                  //MessageBox.Show(idemploit.ToString());
                    f.ismodfi(1);
                    f.updateemploitemp(d);
                    f.idemploitemp(d.Id);
                    f.Show();
                   
                      
                   
                }
                if (e.ColumnIndex == 4 && MessageBox.Show("voulez vous supprimer ce emploi de temps", "Information dialog", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
        public int idemploi(int id)
        {
            return id;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            emploisTempBindingSource.MoveFirst();
            EmploisTemp d = (EmploisTemp)emploisTempBindingSource.Current;
            label4.Text = d.Anneeformation.ToString();
            label5.Text = d.DateDebut.ToLongDateString();
            label6.Text = d.DateFin.ToLongTimeString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emploisTempBindingSource.MovePrevious();
            EmploisTemp d = (EmploisTemp)emploisTempBindingSource.Current;
            label4.Text = d.Anneeformation.ToString();
            label5.Text = d.DateDebut.ToLongDateString();
            label6.Text = d.DateFin.ToLongTimeString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            emploisTempBindingSource.MoveNext();
            EmploisTemp d = (EmploisTemp)emploisTempBindingSource.Current;
            label4.Text = d.Anneeformation.ToString();
            label5.Text = d.DateDebut.ToLongDateString();
            label6.Text = d.DateFin.ToLongTimeString();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            emploisTempBindingSource.MoveLast();
            EmploisTemp d = (EmploisTemp)emploisTempBindingSource.Current;
            label4.Text = d.Anneeformation.ToString();
            label5.Text = d.DateDebut.ToLongDateString();
            label6.Text = d.DateFin.ToLongDateString();
           
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {

            EmploisTemp d = new EmploisTemp();

            d.Anneeformation = (PackageAnneeFormations.AnneeFormation)anneeFormationBindingSource.Current;
            //d.DateDebut = (DateTime)comboBox2.SelectedItem;
            //d.DateFin = (DateTime)comboBox3.SelectedItem;
            MessageBox.Show(d.Anneeformation.Id.ToString());
            //  emploisTempBindingSource.DataSource = EmploisTempDAO.rechercheparanne(d.Anneeformation.Id);
               emploisTempBindingSource.DataSource = new EmploisTempDAO().FindByemploitemp(d.Anneeformation.Id,comboBox2.SelectedItem.ToString(),comboBox3.SelectedItem.ToString());
              // MessageBox.Show(comboBox2.SelectedItem.ToString());
              // MessageBox.Show(comboBox3.SelectedItem.ToString());
            //d.DateFin = (DateTime)comboBox3.SelectedItem;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

