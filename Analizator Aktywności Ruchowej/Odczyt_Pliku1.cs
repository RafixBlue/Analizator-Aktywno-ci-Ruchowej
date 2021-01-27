using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Linq.Expressions;

namespace Analizator_Aktywności_Ruchowej
{
    class Odczyt_Pliku1
    {
        Database databaseObject = new Database();
        public void odczyt(string file_path,string Profil)
        {
            int IDD;
            int counter = 0;
            string line;
            //string path = @"Pliki do Odczytu\" + file_name;
            int kroki_dnia=0;
            int iID;
            int IDG;

            String selectIDG = "SELECT MAX(IDG) FROM Godzina";
            SQLiteCommand Command6 = new SQLiteCommand(selectIDG, databaseObject.Connection);
            databaseObject.openConnection();

            var reader = Command6.ExecuteReader();
            reader.Read();
            String sIDG = String.Format("{0}", reader[0]);
            if(sIDG != null)
            {
                IDG = toInt(sIDG) + 1;
            }
            else
            {
                IDG = 1;
            }
            
            reader.Close();
            databaseObject.closeConnection();
            Command6.Dispose();

            System.IO.StreamReader file = new System.IO.StreamReader(file_path);

            line = file.ReadLine();
            int day = toInt(line);
            line = file.ReadLine();
            int month = toInt(line);
            line = file.ReadLine();
            int year = toInt(line);
            IDD = day + month * 100 + year * 10000;
            // IDD liczba dni w systemie max+1*10^8 + rok*10^4 + miesiac*100 + dzien
            String comboselect = "SELECT MAX(IDD) FROM Dzien";
            SQLiteCommand Command = new SQLiteCommand(comboselect, databaseObject.Connection);

            databaseObject.openConnection();

            var reader2 = Command.ExecuteReader();
            reader2.Read();
            String ID = String.Format("{0}", reader2[0]);
            reader2.Close();
            databaseObject.closeConnection();
            Command.Dispose();
            
            
            
            //String ID="";
            if(ID.Length==0){
                ID = "1";
            }
            else{
                ID=ID.Substring(0, 1);
            }
            iID= Convert.ToInt32(ID)+1;
            IDD = IDD + iID * 100000000;

            string akcja = "INSERT INTO Godzina(`IDG`,`IDD`,`Pelna`,`Kwadrans`,`Polowa`,`trzykwadranse`) Values(@IDG, @IDD, @Pelna, @Kwadrans, @Polowa,@trzykwadranse)";

            

            SQLiteCommand Command2 = new SQLiteCommand(akcja, databaseObject.Connection);
            
            databaseObject.openConnection();

            while ((line = file.ReadLine()) != null)
            {
                
                Command2.Parameters.AddWithValue("@IDD", IDD);
                Command2.Parameters.AddWithValue("@IDG", IDG);
                kroki_dnia = kroki_dnia+toInt(line);
                Command2.Parameters.AddWithValue("@Pelna", toInt(line));
                line = file.ReadLine();
                kroki_dnia = kroki_dnia + toInt(line);
                Command2.Parameters.AddWithValue("@Kwadrans", toInt(line));
                line = file.ReadLine();
                kroki_dnia = kroki_dnia + toInt(line);
                Command2.Parameters.AddWithValue("@Polowa", toInt(line));
                line = file.ReadLine();
                kroki_dnia = kroki_dnia + toInt(line);
                Command2.Parameters.AddWithValue("@trzykwadranse", toInt(line));
                Command2.ExecuteNonQuery();
                IDG++;
            }
            databaseObject.closeConnection();
            Command2.Dispose();

            file.Close();

            
            string akcja2 = "INSERT INTO Dzien(`IDD`,`Nazwa`,`Numer`,`Miesiac`,`Rok`,`Kroki`) Values(@IDD, @Nazwa, @Numer, @Miesiac, @Rok,@Kroki)";
            SQLiteCommand Command3 = new SQLiteCommand(akcja2, databaseObject.Connection);
            databaseObject.openConnection();
            Command3.Parameters.AddWithValue("@IDD", IDD);
            Command3.Parameters.AddWithValue("@Nazwa", Profil);
            Command3.Parameters.AddWithValue("@Numer", day);
            Command3.Parameters.AddWithValue("@Miesiac", month);
            Command3.Parameters.AddWithValue("@Rok", year);
            Command3.Parameters.AddWithValue("@Kroki",kroki_dnia);
            Command3.ExecuteNonQuery();

            databaseObject.closeConnection();
            Command3.Dispose();
            

            //System.Console.WriteLine("There were {0} lines.", counter);
             
            System.Console.ReadLine();
        }
        private int toInt(string s)
        {
            int i = Convert.ToInt32(s);
            return i;
        }
    }
    
}
