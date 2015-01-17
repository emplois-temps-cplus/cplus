using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageFormateurs;
using CompetencePlus.PackageModules;
using CompetencePlus.PackageGroupes;
using CompetencePlus.PackageAnneeFormations;

namespace CompetencePlus.PackageFormations
{
  public  class Formation
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        Formateur formateur;

        public Formateur Formateur
        {
            get { return formateur; }
            set { formateur = value; }
        }
        Module module;

        public Module Module
        {
            get { return module; }
            set { module = value; }
        }
        Groupe groupe;

        public Groupe Groupe
        {
            get { return groupe; }
            set { groupe = value; }
        }
        AnneeFormation anneformation;

        public AnneeFormation Anneformation
        {
            get { return anneformation; }
            set { anneformation = value; }
        }
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public Formation(int id, Formateur formateur, Module module, Groupe groupe, AnneeFormation anneformation, string code)
        {
            this.id = id;
            this.code = code;
            this.formateur = formateur;
            this.module = module;
            this.groupe = groupe;
            this.anneformation = anneformation;
        }
      public Formation()
      {
      }
      public Formation(int id,string code)
      {
          this.id = id;
          this.code = code;
      }
      public override string ToString()
      {

          return code;
      }

    }
}
