﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Analizator_Aktywności_Ruchowej
{
    class Database
    {
        public SQLiteConnection Connection;

        public Database()
        {
            Connection = new SQLiteConnection("Data Source=database.BazaKrokow");

            if (!File.Exists("./database.BazaKrokow")) 
            {
                SQLiteConnection.CreateFile("database.BazaKrokow");
                String createTable1 = ("CREATE TABLE Profil(Nazwa TEXT PRIMARY KEY,Wiek  INTEGER,Waga  INTEGER,Wzrost    INTEGER,Kroki INTEGER);");
                String createTable2 = ("CREATE TABLE Godzina(IDG INTEGER PRIMARY KEY,IDD  INTEGER,Pelna  INTEGER,Kwadrans    INTEGER,Polowa INTEGER, trzykwadranse INTEGER);");
                String createTable3 = ("CREATE TABLE Dzien(IDD INTEGER PRIMARY KEY,Nazwa  TEXT,Numer  INTEGER,Miesiac INTEGER,Rok INTEGER,Kroki INTEGER);");
                string insert = "INSERT INTO Godzina(`IDG`,`IDD`,`Pelna`,`Kwadrans`,`Polowa`,`trzykwadranse`) Values(@IDG, @IDD, @Pelna, @Kwadrans, @Polowa,@trzykwadranse)";
                SQLiteCommand Command = new SQLiteCommand(createTable1, Connection);
                SQLiteCommand Command2 = new SQLiteCommand(createTable2, Connection);
                SQLiteCommand Command3 = new SQLiteCommand(createTable3, Connection);
                SQLiteCommand Command4 = new SQLiteCommand(insert, Connection);
                Command4.Parameters.AddWithValue("@IDG", 1);
                Command4.Parameters.AddWithValue("@IDD", 1);
                Command4.Parameters.AddWithValue("@Pelna", 1);
                Command4.Parameters.AddWithValue("@Kwadrans", 1);
                Command4.Parameters.AddWithValue("@Polowa", 1);
                Command4.Parameters.AddWithValue("@trzykwadranse", 1);
                openConnection();
                Command.ExecuteNonQuery();
                Command2.ExecuteNonQuery();
                Command3.ExecuteNonQuery();
                Command4.ExecuteNonQuery();
                closeConnection();

            }
        }
        public void openConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        public void closeConnection()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
                //SQLiteConnection.ClearAllPools();
            }
        }
    }
    
}
