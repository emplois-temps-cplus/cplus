using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompetencePlus.PackageAnneeFormations
{
  public  class AnneeFormation
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string titre;

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        private DateTime datedebut;

        public DateTime Datedebut
        {
            get { return datedebut; }
            set { datedebut = value; }
        }
        private DateTime datefin;

        public DateTime Datefin
        {
            get { return datefin; }
            set { datefin = value; }
        }

      public AnneeFormation(int id,string titre,DateTime datedebut,DateTime datefin)
      {
          this.id = id;
          this.titre = titre;
          this.datedebut = datedebut;
          this.datefin = datefin;
          
      }
      public AnneeFormation()
      {
      }
      public override string ToString()
      {
          return titre;
      }


    }
}
