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
           

        }
        public static List<EmploisTemp> afficherdatedebut(DateTime datedebut)
        {
            List<EmploisTemp> listeemploitemp = new List<EmploisTemp>();
            string requete;
            requete = "select * from EmploisTemps  where dateDebut='" + datedebut + "'";
            OleDbDataReader read = MyConnection.ExecuteReader(requete);
            while (read.Read())
            {
                EmploisTemp d = new EmploisTemp();
                d.Anneeformation = new PackageAnneeFormations.AnneformationDAO().findbyid(read.GetInt32(3));
                d.DateDebut = read.GetDateTime(1);
                d.DateFin = read.GetDateTime(2);

                listeemploitemp.Add(d);
            }
            MyConnection.Close();
            return listeemploitemp;



        }
        public static List<EmploisTemp> rechercherdatefin(DateTime datefin)
        {
            List<EmploisTemp> listeemploitemp = new List<EmploisTemp>();
            string requete;
            requete = "select * from EmploisTemps  where dateFin='" + datefin+"'";
            OleDbDataReader read = MyConnection.ExecuteReader(requete);
            while (read.Read())
            {
                EmploisTemp d = new EmploisTemp();
                d.Anneeformation = new PackageAnneeFormations.AnneformationDAO().findbyid(read.GetInt32(3));
                d.DateDebut = read.GetDateTime(1);
                d.DateFin = read.GetDateTime(2);

                listeemploitemp.Add(d);
            }
            MyConnection.Close();
            return listeemploitemp;



        }
        public static List<EmploisTemp> rechercheparanne (int id)
        {
            List<EmploisTemp> listeemploitemp = new List<EmploisTemp>();
            string requete;
            requete = "select * from EmploisTemps  where anneformation_id = " + id;
            OleDbDataReader read = MyConnection.ExecuteReader(requete);
            while (read.Read())
            {
                

               
                listeemploitemp.Add(new EmploisTemp(read.GetInt32(0),read.GetDateTime(1), read.GetDateTime(2),new PackageAnneeFormations.AnneformationDAO().findbyid(read.GetInt32(3))));
            }
            MyConnection.Close();
            return listeemploitemp;



        }



        public List<EmploisTemp> FindByemploitemp(int id,string datedebut,string datefin)
        {

            string Requete = "Select * from EmploisTemps ";
            if (id != null || datedebut != null || datefin!= null)
            {
                Requete += " where ";


            }
            bool and = false;
            if (id!= null)
            {
                Requete += " anneeformation_id like '%" + id+ "%'";
                and = true;
            }
            if (datedebut != null)
            {
                if (and) Requete += " and ";
                Requete += "dateDebut  like '%" + datedebut+ "%'";
                and = true;
            }
            if (datefin!= null)
            {
                if (and) Requete += " and ";
                Requete += " DateFin like '%" + datefin + "%'";
                and = true;
            }
            

            List<EmploisTemp> Listemploi = new List<EmploisTemp>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {

                Listemploi.Add(new EmploisTemp(read.GetInt32(0), (DateTime)read["dateDebut"], (DateTime)read["dateFin"], new PackageAnneeFormations.AnneformationDAO().findbyid(read.GetInt32(3))));
           
            }
            MyConnection.Close();
            return Listemploi;


        }

    }
}
