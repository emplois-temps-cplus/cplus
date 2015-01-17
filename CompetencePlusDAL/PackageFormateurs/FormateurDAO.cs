using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Tools;

namespace CompetencePlus.PackageFormateurs
{
  public  class FormateurDAO
    {
      public List<Formateur> select()
      {
          List<Formateur> lstformateur = new List<Formateur>();
          string reqeute = "select * from Formateurs";
          OleDbDataReader lire = MyConnection.ExecuteReader(reqeute);
          while(lire.Read())
          {

              lstformateur.Add(new Formateur(lire.GetInt32(0),lire.GetString(1),lire.GetString(2),lire.GetString(3),lire.GetString(4),lire.GetString(5),lire.GetString(6)));
          }


          return lstformateur;
      }

      public Formateur findbyid(int id)
      {
          List<Formateur> lstformateur = new List<Formateur>();
          string reqeute = "select * from Formateurs where Id="+id;
          OleDbDataReader lire = MyConnection.ExecuteReader(reqeute);
          while(lire.Read())
          {

              lstformateur.Add(new Formateur(lire.GetInt32(0),lire.GetString(1),lire.GetString(2),lire.GetString(3),lire.GetString(4),lire.GetString(5),lire.GetString(6)));
          }


          return lstformateur.ElementAt(0);
      }

      }

    }

