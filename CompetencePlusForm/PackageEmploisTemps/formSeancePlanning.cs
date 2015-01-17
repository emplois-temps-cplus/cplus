using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageEmploisTemps;
using CompetencePlusForm;

namespace CompetencePlus.PackageEmploisTemps
{
    public partial class formSeancePlanning : Form
    {
        public formSeancePlanning()
        {
            InitializeComponent();
        }

        private void btannuler_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        int id=3;
      

        private void btenregistrer_Click(object sender, EventArgs e)
        {
            
            Seanceplanning s = new Seanceplanning();
            s.Emploitemp = (EmploisTemp)new EmploisTempDAO().FindById(id);
            s.Id = 1;
            s.Heuredebut = userControltime1.Hm;
            s.Heurefin = userControltime2.Hm;
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
            if (jeudiradio.Checked)
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
         s.Formation = (PackageFormations.Formation)formationBindingSource.Current;
         new SeanceplanningDAO().Add(s);
         MessageBox.Show(s.Jour+""+s.Heurefin+""+s.Heuredebut+""+s.Formation);
         this.Dispose();
        }
        private void formSeancePlanning_Load(object sender, EventArgs e)
        {
            formationBindingSource.DataSource = new PackageFormations.FormationDAO().select();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
      
    }
}
