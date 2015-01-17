using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Tools;

namespace CompetencePlus.PackageAnneeFormations
{
  public  class AnneformationDAO
    {
      public List<AnneeFormation> select()
      {
          List<AnneeFormation> lstanneformation = new List<AnneeFormation>();
          string rqt = "select *from AnneeFormations";
          OleDbDataReader lire = MyConnection.ExecuteReader(rqt);
          while(lire.Read())
          {
              lstanneformation.Add(new AnneeFormation(lire.GetInt32(0),lire.GetString(1),lire.GetDateTime(2),lire.GetDateTime(3)));
          }
          return lstanneformation;
      }
      public AnneeFormation findbyid(int id)
      {
          List<AnneeFormation> lstanneformation = new List<AnneeFormation>();
          string rqt = "select * from AnneeFormations where id="+id;
          OleDbDataReader lire = MyConnection.ExecuteReader(rqt);
          while (lire.Read())
          {
              lstanneformation.Add(new AnneeFormation(lire.GetInt32(0), lire.GetString(1), lire.GetDateTime(2), lire.GetDateTime(3)));
          }
          return lstanneformation.ElementAt(0);
      }
    }
}
