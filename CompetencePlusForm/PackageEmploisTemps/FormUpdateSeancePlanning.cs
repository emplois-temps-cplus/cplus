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
    public partial class FormUpdateSeancePlanning : Form
    {
        public FormUpdateSeancePlanning()
        {
            InitializeComponent();
        }
          int id = 0;

        
        public void update(Seanceplanning s)
        {
            id = s.Id;
            MessageBox.Show(id.ToString());
            string chaine2 = s.Heurefin;
            string chaine = s.Heuredebut;
            string[] remplir2 = chaine2.Split(':');
            string[] remplir = chaine.Split(':');
            formationBindingSource.DataSource = s.Formation;
            userControltime1.Hour = remplir[0].ToString();
            userControltime1.Min = remplir[1].ToString();
            userControltime2.Hour = remplir2[0].ToString();
            userControltime2.Min = remplir2[1].ToString();
            if (s.Jour != null && s.Jour == "Lundi")
            {
                Lundiradio.Checked = true;
            }
            if (s.Jour != null && s.Jour == "Mardi")
            {
                mardiradio.Checked = true;
            }
            if (s.Jour != null && s.Jour == "Jeudi")
            {
                jeudiradio.Checked = true;
            }
            if (s.Jour != null && s.Jour == "Mercredi")
            {
                mercrediradio.Checked = true;
            }
            if (s.Jour != null && s.Jour == "Vendredi")
            {
                vendrediradio.Checked = true;
            }
            if (s.Jour != null && s.Jour == "Samedi")
            {
                samediradio.Checked = true;
            }
            if (s.Jour != null && s.Jour == "Dimanche")
            {
                dimancheradio.Checked = true;
            }
           
        
        }
         

        private void btenregistrer_Click(object sender, EventArgs e)
        {

            Seanceplanning s = new Seanceplanning();
            
            if (Lundiradio.Checked)
            {
                s.Jour = "Lundi";
            }
            if (mardiradio.Checked)
            {
                s.Jour = "Mardi";
            }
            if (mercrediradio.Checked)
            {
                s.Jour = "Mercredi";
            }
            if (jeudiradio.Checked )
            {
                s.Jour = "Jeudi";
            }
            if (vendrediradio.Checked)
            {
                s.Jour = "Vendredi";
            }
            if (samediradio.Checked)
            {
                s.Jour = "Samedi";
            }
            if (dimancheradio.Checked)
            {
                s.Jour = "Dimanche";
            }
            s.Heuredebut = userControltime1.Hm;
            s.Heurefin = userControltime2.Hm;
            s.Formation = (PackageFormations.Formation)formationBindingSource.Current;
            s.Id = 10; 

            new SeanceplanningDAO().Update(s);
            this.Dispose();
       
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      
    }
}
