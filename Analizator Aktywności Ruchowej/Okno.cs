using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Linq.Expressions;

namespace Analizator_Aktywności_Ruchowej
{
    public partial class Okno : Form
    {
        Database databaseObject = new Database();
        int Profil_wybor;
        int Baza_Wybor;
        public Okno()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void But_Zarz_Prof_Click(object sender, EventArgs e)
        {
            Panel_Danych.Visible = false;
            Panel_Analizy.Visible = false;
            Panel_Profili.Visible = true;
        }

        private void But_Analiza_Danych_Click(object sender, EventArgs e)
        {
            Panel_Danych.Visible = false;
            Panel_Analizy.Visible = true;
            Panel_Profili.Visible = false;
        }

        private void But_Zarz_Dan_Click(object sender, EventArgs e)
        {
            Panel_Danych.Visible = true;
            Panel_Analizy.Visible = false;
            Panel_Profili.Visible = false;
        }

        private void But_Dod_Prof_Click(object sender, EventArgs e)
        {
            czyszczenie_Profil();
            Panel_Akcji_Profili.Visible = true;
            Panel_Akcji_Bazy.Visible = false;
            Textbox_Name.Visible = true;
            comboBox_Nazwa.Visible = false;
            Profil_wybor = 1;
        }

        private void But_Edyt_Prof_Click(object sender, EventArgs e)
        {
            czyszczenie_Profil();
            Panel_Akcji_Profili.Visible = true;
            Panel_Akcji_Bazy.Visible = false;
            Textbox_Name.Visible = false;
            comboBox_Nazwa.Visible = true;
            Profil_wybor = 2;

            combo_wypelnienie();
            
        }

        private void But_Usun_Prof_Click(object sender, EventArgs e)
        {
            czyszczenie_Profil();
            Panel_Akcji_Profili.Visible = true;
            Panel_Akcji_Bazy.Visible = false;
            Textbox_Name.Visible = false;
            comboBox_Nazwa.Visible = true;
            Profil_wybor = 3;

            combo_wypelnienie();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Name=" ";
            string akcja = " ";
            if (Profil_wybor == 1)
            {
                akcja = "INSERT INTO Profil(`Nazwa`,`Wiek`,`Waga`,`Wzrost`,`Kroki`) Values(@Nazwa,@Wiek,@Waga,@Wzrost,@Kroki)";
                Name = Textbox_Name.Text;
                zmiany_bazy(Name,akcja);
                czyszczenie_Profil();
                combo_wypelnienie();
            }
            else if(Profil_wybor == 2)
            {
                akcja = "UPDATE Profil SET Wiek = @Wiek, Waga=@Waga, Wzrost =@Wzrost,Kroki= @Kroki Where Nazwa = @Nazwa ";
                Name = comboBox_Nazwa.Text;
                zmiany_bazy(Name,akcja);
                czyszczenie_Profil();
                combo_wypelnienie();
            }
            else if(Profil_wybor == 3)
            {
                akcja = "DELETE FROM Profil WHERE Nazwa = @Nazwa";
                Name = comboBox_Nazwa.Text;

                delete_baza(Name, akcja);

                czyszczenie_Profil();
                combo_wypelnienie();
            }

            

        }

        private void comboBox_Nazwa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            String wypelnianie = "SELECT Wiek,Waga,Wzrost,Kroki FROM Profil Where Nazwa = @Nazwa";

            SQLiteCommand Command = new SQLiteCommand(wypelnianie, databaseObject.Connection);
            databaseObject.openConnection();

            String Name = comboBox_Nazwa.Text;

            Command.Parameters.AddWithValue("@Nazwa", Name);

            var reader = Command.ExecuteReader();
            reader.Read();
            textBox_Wiek.Text = String.Format("{0}", reader[0]);
            textBox_Waga.Text = String.Format("{0}", reader[1]);
            textBox_Wzrost.Text = String.Format("{0}", reader[2]);
            textBox_Dl_Kroku.Text = String.Format("{0}", reader[3]);
            reader.Close();
            databaseObject.closeConnection();
            Command.Dispose();

            /*while (reader.Read())
            {

                textBox_Wiek.Text = String.Format("{0}", reader[0]);
                textBox_Waga.Text = String.Format("{0}", reader[1]);
                textBox_Wzrost.Text = String.Format("{0}", reader[2]);
                textBox_Dl_Kroku.Text = String.Format("{0}", reader[3]);
            }*/

        }

        private void czyszczenie_Profil()
        {
            textBox_Wzrost.Text = "";
            textBox_Waga.Text = "";
            textBox_Wiek.Text = "";
            Textbox_Name.Text = "";
            textBox_Dl_Kroku.Text = "";
            comboBox_Nazwa.Items.Clear();

        }

        private int toInt(String a)
        {
            int x = Convert.ToInt32(a);
            return x;
        }

        private void combo_wypelnienie()
        {
            String comboselect = "SELECT Nazwa FROM Profil ORDER BY Nazwa";
            SQLiteCommand Command = new SQLiteCommand(comboselect, databaseObject.Connection);
            
            databaseObject.openConnection();

            var reader = Command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_Nazwa.Items.Add(String.Format("{0}", reader[0]));
                comboBox_Bazy_Profil.Items.Add(String.Format("{0}", reader[0]));
            }
            reader.Close();
            databaseObject.closeConnection();
            Command.Dispose();

        }

        private void zmiany_bazy(String Nazwa, String akcja)
        {

            SQLiteCommand Command = new SQLiteCommand(akcja, databaseObject.Connection);

            databaseObject.openConnection();

            int iWiek = toInt(textBox_Wiek.Text);
            int iWaga = toInt(textBox_Waga.Text);
            int iWzrost = toInt(textBox_Wzrost.Text);
            int idlkroku = toInt(textBox_Dl_Kroku.Text);

            Command.Parameters.AddWithValue("@Nazwa", Nazwa);
            Command.Parameters.AddWithValue("@Wiek", iWiek);
            Command.Parameters.AddWithValue("@Waga", iWaga);
            Command.Parameters.AddWithValue("@Wzrost", iWzrost);
            Command.Parameters.AddWithValue("@Kroki", idlkroku);
            Command.ExecuteNonQuery();

            databaseObject.closeConnection();
            Command.Dispose();
        }

        private void delete_baza(String Nazwa, String akcja)
        {
            SQLiteCommand Command = new SQLiteCommand(akcja, databaseObject.Connection);
            databaseObject.openConnection();
           

            Command.Parameters.AddWithValue("@Nazwa", Nazwa);

            Command.ExecuteNonQuery();

            databaseObject.closeConnection();

            Command.Dispose();
        }


        ///////////////////////// panel baza ////////////////////////////////
        private void button3_Click(object sender, EventArgs e)
        {
            if(Baza_Wybor == 1)
            {
                OpenFileDialog ka = new OpenFileDialog();
                ka.ShowDialog();
                Odczyt_Pliku1 Odczyt = new Odczyt_Pliku1();
                Odczyt.odczyt(ka.FileName, comboBox_Bazy_Profil.Text);
                
                czyszczenie_baza();
                combo_wypelnienie();

            }
            else if(Baza_Wybor == 2)
            {
                String IDD="";
                String znajdz = "SELECT IDD FROM Dzien Where Nazwa = @Nazwa AND Rok = @Rok AND Miesiac = @Month AND Numer = @Numer";
                SQLiteCommand Command = new SQLiteCommand(znajdz, databaseObject.Connection);
                databaseObject.openConnection();

                String Name = comboBox_Bazy_Profil.Text;
                String Rok = comboBox_year.Text;
                String Month = comboBox_month.Text;
                String Numer = comboBox_day.Text;

                Command.Parameters.AddWithValue("@Nazwa", Name);
                Command.Parameters.AddWithValue("@Rok", Rok);
                Command.Parameters.AddWithValue("@Month", Month);
                Command.Parameters.AddWithValue("@Numer", Numer);
                var reader = Command.ExecuteReader();

                databaseObject.openConnection();
                while (reader.Read())
                {

                    IDD = String.Format("{0}", reader[0]);

                }
                reader.Close();
                databaseObject.closeConnection();
                Command.Dispose();

                int iIDD = toInt(IDD);

                String usuwanie = "DELETE FROM Dzien Where IDD = @IDD";
                SQLiteCommand Command2 = new SQLiteCommand(usuwanie, databaseObject.Connection);

                databaseObject.openConnection();
                Command2.Parameters.AddWithValue("@IDD", iIDD);
                Command2.ExecuteNonQuery();

                databaseObject.closeConnection();
                Command2.Dispose();

                String usuwanie2 = "DELETE FROM Godzina Where IDD = @IDD";
                SQLiteCommand Command3 = new SQLiteCommand(usuwanie2, databaseObject.Connection);

                databaseObject.openConnection();
                Command3.Parameters.AddWithValue("@IDD", iIDD);
                Command3.ExecuteNonQuery();

                databaseObject.closeConnection();
                Command3.Dispose();
                czyszczenie_baza();
                combo_wypelnienie();

            }
            

        }

        private void But_Usun_Dane_Click(object sender, EventArgs e)
        {
            Panel_Akcji_Profili.Visible = false;
            Panel_Akcji_Bazy.Visible = true;
            comboBox_day.Visible = true;
            comboBox_month.Visible = true;
            comboBox_year.Visible = true;
            czyszczenie_baza();
            combo_wypelnienie();
            Baza_Wybor = 2;
        }

        private void But_Dod_Dane_Click(object sender, EventArgs e)
        {
            Panel_Akcji_Profili.Visible = false;
            Panel_Akcji_Bazy.Visible = true;
            comboBox_day.Visible = false;
            comboBox_month.Visible = false;
            comboBox_year.Visible = false;
            czyszczenie_baza();
            combo_wypelnienie();
            Baza_Wybor=1;

        }

        private void czyszczenie_baza()
        {
            comboBox_Bazy_Profil.Items.Clear();
            comboBox_day.Items.Clear();
            comboBox_month.Items.Clear();
            comboBox_year.Items.Clear();
            
            
        }

        private void comboBox_Bazy_Profil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String wypelnianie = "SELECT Rok FROM Dzien Where Nazwa = @Nazwa";

            SQLiteCommand Command = new SQLiteCommand(wypelnianie, databaseObject.Connection);
            databaseObject.openConnection();

            String Name = comboBox_Bazy_Profil.Text;

            Command.Parameters.AddWithValue("@Nazwa", Name);

            var reader = Command.ExecuteReader();

            databaseObject.openConnection();
            while (reader.Read())
            {

                comboBox_year.Items.Add(String.Format("{0}", reader[0]));
            }
            reader.Close();
            databaseObject.closeConnection();
            Command.Dispose();

        }

        private void comboBox_year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String wypelnianie = "SELECT Miesiac FROM Dzien Where Nazwa = @Nazwa AND Rok = @Rok";

            SQLiteCommand Command = new SQLiteCommand(wypelnianie, databaseObject.Connection);
            databaseObject.openConnection();

            String Name = comboBox_Bazy_Profil.Text;
            String Rok = comboBox_year.Text;
            Command.Parameters.AddWithValue("@Nazwa", Name);
            Command.Parameters.AddWithValue("@Rok", Rok);
            var reader = Command.ExecuteReader();

            databaseObject.openConnection();
            while (reader.Read())
            {

                comboBox_month.Items.Add(String.Format("{0}", reader[0]));
            }
            reader.Close();
            databaseObject.closeConnection();
            Command.Dispose();
        }

        private void comboBox_month_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String wypelnianie = "SELECT Numer FROM Dzien Where Nazwa = @Nazwa AND Rok = @Rok AND Miesiac = @Month";

            SQLiteCommand Command = new SQLiteCommand(wypelnianie, databaseObject.Connection);
            databaseObject.openConnection();

            String Name = comboBox_Bazy_Profil.Text;
            String Rok = comboBox_year.Text;
            String Month = comboBox_month.Text;

            Command.Parameters.AddWithValue("@Nazwa", Name);
            Command.Parameters.AddWithValue("@Rok", Rok);
            Command.Parameters.AddWithValue("@Month", Month);
            var reader = Command.ExecuteReader();

            databaseObject.openConnection();
            while (reader.Read())
            {

                comboBox_day.Items.Add(String.Format("{0}", reader[0]));

            }
            reader.Close();
            databaseObject.closeConnection();
            Command.Dispose();
        }

        
        
    }
}
