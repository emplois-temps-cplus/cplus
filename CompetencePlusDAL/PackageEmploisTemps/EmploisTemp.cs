using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageAnneeFormations;
namespace CompetencePlus.PackageEmploisTemps
{
  public  class EmploisTemp
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime dateDebut;

        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }
        private DateTime dateFin;
        public DateTime DateFin
        {
            get { return dateFin; }
            set { dateFin = value; }
        }

   
        AnneeFormation anneeformation;

        public AnneeFormation Anneeformation
        {
            get { return anneeformation; }
            set { anneeformation = value; }
        }
       
        public EmploisTemp(int id,DateTime datedebut,DateTime datefin,AnneeFormation anneformation)
        {
            this.id = id;
            this.DateDebut = datedebut;
            this.dateFin = datefin;
            this.anneeformation = anneeformation;
        }
        public EmploisTemp(int id, DateTime datedebut, DateTime datefin)
        {
            this.id = id;
            this.DateDebut = datedebut;
            this.dateFin = datefin;
          
        }


        public override string ToString()
        {
            return id.ToString();
        }
 
      public EmploisTemp()
      {
      }



    }
}
