using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace plkj
{
    static class DataAccess
    {
        static string cnstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\USER\Downloads\Database Food (1).accdb";
            //ConfigurationManager.ConnectionStrings["MaConnectionAccess"].ConnectionString;

        static OleDbConnection cn = new OleDbConnection();
        //static string cnstrSQLite =
        //ConfigurationManager.ConnectionStrings["MaConnectionSQLite"].ConnectionString;
        //static SqliteConnection cnSQLite = new SqliteConnection(); 
        
        static void Connect()//Permet de se connecter à la BD
        { cn.ConnectionString = cnstr;
            cn.Open();
            //cnSQLite.ConnectionString = cnstrSQLite;
            //cnSQLite.Open();
            //cnSQLite.Close();
        }
        public static void Disconnect()
        //Permet de fermer la connexion 
        { cn.Close(); }

        public static void MettreAjour(string req)
        // Permet la mise à jour
        {//insert , update ou delete
            Connect();
            OleDbCommand cmd = new OleDbCommand(req, cn);
            cmd.ExecuteNonQuery();
            Disconnect(); }

        public static int MettreAjour2(string req)
        // Permet la mise à jour en retournant le nombre de lignes mis à jour
        {//insert , update ou delete
            Connect();
            OleDbCommand cmd = new OleDbCommand(req, cn);
            int nblignes =cmd.ExecuteNonQuery();
            Disconnect();
            return nblignes;
        }
        public static OleDbDataReader LireDataReader(string req)
        //Permet de retourner un DataReader
        //On doit ajouter disconnect après l'utilisation de cette méthode
        {
            Connect();
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            return rd;
        }
        public static DataTable LireDataTable(string req)
        {   Connect();//Aucune valeur donnée pour un ou plusieurs des paramètres re
            OleDbCommand cmd = new OleDbCommand(req, cn);
            OleDbDataReader rd = cmd.ExecuteReader();
            DataTable DT = new DataTable();
            DT.Load(rd);
            Disconnect();
            return DT; }
    }
    static class DataAccess<T> where T : class, new()
    {
        public static List<T> LireListe(string req)
        //Permet de retourner une liste des données retournées
        {
            OleDbDataReader RD = DataAccess.LireDataReader(req);

            List<T> ListObject = new List<T>();
            while (RD.Read())
            {
                T objet = new T();

                for(int i=0;i< RD.VisibleFieldCount;i++)
                {
                    if(objet.GetType().GetField(RD.GetName(i))!=null)
                        objet.GetType().GetField(RD.GetName(i)).SetValue(objet, RD.GetValue(i));
                    if (objet.GetType().GetProperty(RD.GetName(i)) != null)
                        objet.GetType().GetProperty(RD.GetName(i)).SetValue(objet, RD.GetValue(i));
                }
                ListObject.Add(objet);
            }
            DataAccess.Disconnect();

            return ListObject;
        }

        public static T LirePremier(string req)
        //Permet de retourner une donnée
        {
            return LireListe(req).FirstOrDefault();
        }
    }
}
