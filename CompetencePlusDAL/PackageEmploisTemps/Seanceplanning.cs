using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageFormations;

namespace CompetencePlus.PackageEmploisTemps
{
  public class Seanceplanning
    {

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

      private string heuredebut;
     
        public string Heuredebut
        {
            get { return heuredebut; }
            set { heuredebut = value; }
        }
       
        private string heurefin;
        public string Heurefin
        {
            get { return heurefin; }
            set { heurefin = value; }
        }
        private string jour;
        public string Jour
        {
            get { return jour; }
            set { jour = value; }
        }
        Formation formation;

        public Formation Formation
        {
            get { return formation; }
            set { formation = value; }
        }
        EmploisTemp emploitemp;


        public EmploisTemp Emploitemp
        {
            get { return emploitemp; }
            set { emploitemp = value; }
        }

        public Seanceplanning(EmploisTemp emploitemp,int id, string jour,string heuredebut,string heurefin, Formation formation)
        {
            this.emploitemp = emploitemp;
            this.id = id;
            this.heuredebut = heuredebut;
            this.heurefin = heurefin;
            this.jour = jour;
            this.formation = formation;
        }
        public Seanceplanning()
        {
          
        }
    }
}
