using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Tools;


namespace CompetencePlus.PackageEmploisTemps
{
   public class EmploisTempDAO
    {

        public void Add(EmploisTemp e)
        {
            string Requete = "Insert into  EmploisTemps(dateDebut,dateFin,anneformation_id) values ('" + e.DateDebut + "','" + e.DateFin + "',"+e.Anneeformation.Id+")";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public void Update(EmploisTemp e)
        {
            string Requete = "Update  EmploisTemps set dateDebut='" + e.DateDebut + "',dateFin='" + e.DateFin + "',anneformation_id="+e.Anneeformation.Id+" where id="+e.Id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public void Delete(int id)
        {
            string Requete = "Delete From EmploisTemps where id=" + id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public List<EmploisTemp> Select()
        {
            string Requete = "Select * from EmploisTemps";
            List<EmploisTemp> ListEmploisTemp  = new List<EmploisTemp>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                EmploisTemp f = new EmploisTemp();
                f.Id = read.GetInt32(0);
                f.DateDebut = read.GetDateTime(1);
                f.DateFin = read.GetDateTime(2);
                f.Anneeformation = new PackageAnneeFormations.AnneformationDAO().findbyid(read.GetInt32(3));
                ListEmploisTemp.Add(f);
            }
            MyConnection.Close();
            return ListEmploisTemp;
        }


        public EmploisTemp FindById(int id)
        {
            string Requete = "Select * from EmploisTemps where id=" + id;
            List<EmploisTemp> lstemploi = new List<EmploisTemp>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                EmploisTemp f = new EmploisTemp();

                f.Id = read.GetInt32(0);
                f.DateDebut = read.GetDateTime(1);
                f.DateFin = read.GetDateTime(2);
                f.Anneeformation = new PackageAnneeFormations.AnneformationDAO().findbyid(read.GetInt32(3));
                lstemploi.Add(f);
            }
            return lstemploi.ElementAt(0);
            
        }
        public int GetLastnumber()
        {
            int id = 0;
            string Requete = "Select max(id) from EmploisTemps";
           
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                

                id = read.GetInt32(0);
                break;
            }
            return id;
            // ? good khali hayda nchof
        }

    }
}
