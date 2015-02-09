using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.Outils;
using CompetencePlus.Tools;
using System.Data.OleDb;

namespace CompetencePlus.PackageEmploisTemps
{
 public   class SeanceplanningDAO 
    {
      public  void Add(Seanceplanning s)
     {//EmploisTemp_id
         string Requete = "Insert into SeancePlannings(EmploisTemp_id,jour,heuredebut,heurefin,Formation_id) values ("+s.Emploitemp.Id+",'" + s.Jour + "','" + s.Heuredebut + "','" + s.Heurefin + "'," + s.Formation.Id + ")";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void Update(Seanceplanning s)
        {
            string Requete = "Update  SeancePlannings set jour ='"+s.Jour+"',heuredebut ='"+s.Heuredebut+"',heurefin='"+s.Heurefin+"',Formation_id="+s.Formation.Id+" where id ="+s.Id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void Delete(int id)
        {
            string Requete = "Delete From SeancePlannings where id="+id;
            MyConnection.ExecuteNonQuery(Requete);
        }
     

  public static  List<Seanceplanning> ListSeancePlannings = new List<Seanceplanning>();
        public static  List<Seanceplanning> Select(int id)
        {
            string Requete = "Select * from SeancePlannings where id = "+id;
           
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
               Seanceplanning f = new Seanceplanning();
              f.Emploitemp = new EmploisTempDAO().FindById(new EmploisTempDAO().GetLastnumber());
                f.Id = read.GetInt32(1);
                f.Jour = read.GetString(2);
                f.Heuredebut= read.GetString(3);
                f.Heurefin = read.GetString(4);
                f.Formation = new PackageFormations.FormationDAO().FindById(read.GetInt32(5));
                ListSeancePlannings.Add(f);
            }
            MyConnection.Close();
            return ListSeancePlannings;
        }
        public int Lastnumber()
        {
           //
            int idd=0;
            string Requete = "Select max(id) from SeancePlannings";
            List<Seanceplanning> ListSeancePlannings = new List<Seanceplanning>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                
                idd = read.GetInt32(0);
               
               
            }
            MyConnection.Close();
            return idd;
        }
      

        public Seanceplanning FindById(int id)
        {
            string Requete = "Select * from SeancePlannings where id="+id;
            List<Seanceplanning> lstsance = new List<Seanceplanning>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
               Seanceplanning f = new Seanceplanning();
               f.Emploitemp = new EmploisTempDAO().FindById(new EmploisTempDAO().GetLastnumber());
                f.Id = read.GetInt32(1);
               f.Jour = read.GetString(2);
                f.Heuredebut = read.GetString(3);
                f.Heurefin = read.GetString(4);
                f.Formation = new PackageFormations.FormationDAO().FindById(read.GetInt32(5));
                lstsance.Add(f);
            }
            return lstsance.ElementAt(0);
         
        }

       
    
    }
}
