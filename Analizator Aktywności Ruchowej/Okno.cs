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
        int Analiza_Wybor;
        int Combos_wybor;
        public Okno()
        {
            InitializeComponent();
        }

        private void Zamknij_Program_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Min_Program_Click(object sender, EventArgs e)
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
            panel3.Visible = false;
            Textbox_Name.Visible = true;
            comboBox_Nazwa.Visible = false;
            Profil_wybor = 1;

            textBox_Wiek.Enabled = true;
            textBox_Waga.Enabled = true;
            textBox_Wzrost.Enabled = true;
            textBox_Dl_Kroku.Enabled = true;

            label_profil_nazwa.Text = "Wpisz swoją nazwę użytkownika";
            label_profil_wiek.Text = "Wpisz swój wiek";
            label_profil_waga.Text = "[kg] Wpisz swoją wagę";
            label_profil_wzrost.Text = "[cm] Wpisz swój wzrost";
            label_profil_dlugosc.Text = "[cm] Wpisz długość swojego kroku";

            button1.Text = "Dodaj Profil";

        }

        private void But_Edyt_Prof_Click(object sender, EventArgs e)
        {
            czyszczenie_Profil();
            Panel_Akcji_Profili.Visible = true;
            Panel_Akcji_Bazy.Visible = false;
            panel3.Visible = false;
            Textbox_Name.Visible = false;
            comboBox_Nazwa.Visible = true;
            Profil_wybor = 2;

            combo_wypelnienie();

            textBox_Wiek.Enabled = true;
            textBox_Waga.Enabled = true;
            textBox_Wzrost.Enabled = true;
            textBox_Dl_Kroku.Enabled = true;

            label_profil_nazwa.Text = "Wybierz użytkownika którego chcesz edytować";
            label_profil_wiek.Text = "Edytuj wiek";
            label_profil_waga.Text = "[kg] Edytuj wagę";
            label_profil_wzrost.Text = "[cm] Edytuj wzrost";
            label_profil_dlugosc.Text = "[cm] Edytuj długość kroku";

            button1.Text = "Edytuj Profil";

        }

        private void But_Usun_Prof_Click(object sender, EventArgs e)
        {
            czyszczenie_Profil();
            Panel_Akcji_Profili.Visible = true;
            Panel_Akcji_Bazy.Visible = false;
            panel3.Visible = false;
            Textbox_Name.Visible = false;
            comboBox_Nazwa.Visible = true;
            Profil_wybor = 3;

            textBox_Wiek.Enabled = false;
            textBox_Waga.Enabled = false;
            textBox_Wzrost.Enabled = false;
            textBox_Dl_Kroku.Enabled = false;


            combo_wypelnienie();

            label_profil_nazwa.Text = "Wybierz użytkownika którego chcesz usunąć";
            label_profil_wiek.Text = "Usuwany wiek";
            label_profil_waga.Text = "[kg] Usuwana waga";
            label_profil_wzrost.Text = "[cm] Usuwany wzrost";
            label_profil_dlugosc.Text = "[cm] Usuwana długość kroku";



            button1.Text = "Usuń Profil";
        }

        private void DEU_Profile_Click(object sender, EventArgs e)
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
                comboBox1.Items.Add(String.Format("{0}", reader[0]));
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
        private void DU_Baza_Click(object sender, EventArgs e)
        {
            if(Baza_Wybor == 1)
            {
                try
                {
                    OpenFileDialog ka = new OpenFileDialog();
                    ka.ShowDialog();
                    Odczyt_Pliku1 Odczyt = new Odczyt_Pliku1();
                    Odczyt.odczyt(ka.FileName, comboBox_Bazy_Profil.Text);

                    czyszczenie_baza();
                    combo_wypelnienie();
                }
                catch { }
               

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
            panel3.Visible = false;
            comboBox_day.Visible = true;
            comboBox_month.Visible = true;
            comboBox_year.Visible = true;
            czyszczenie_baza();
            combo_wypelnienie();
            Baza_Wybor = 2;

            label_baza_rok1.Visible = true;
            label_baza_miesiac1.Visible = true;
            label_baza_dzien1.Visible = true;

            label_baza_rok2.Visible = true;
            label_baza_miesiac2.Visible = true;
            label_baza_dzien2.Visible = true;

            label_baza_nazwa.Text = "Wybierz użytkownika któremu chcesz usunąć dane";
            label_baza_rok2.Text = "Wybierz z którego roku dane chcesz usunąć";
            label_baza_miesiac2.Text = "Wybierz z którego miesiąca dane chcesz usunąć";
            label_baza_dzien2.Text = "Wybierz z którego dnia dane chcesz usunąć";

            button3.Text = "Usuń";

            Combos_wybor = 1;
        }

        private void But_Dod_Dane_Click(object sender, EventArgs e)
        {
            Panel_Akcji_Profili.Visible = false;
            Panel_Akcji_Bazy.Visible = true;
            panel3.Visible = false;
            comboBox_day.Visible = false;
            comboBox_month.Visible = false;
            comboBox_year.Visible = false;
            czyszczenie_baza();
            combo_wypelnienie();
            Baza_Wybor=1;

            label_baza_rok1.Visible = false;
            label_baza_miesiac1.Visible = false;
            label_baza_dzien1.Visible = false;

            label_baza_rok2.Visible = false;
            label_baza_miesiac2.Visible = false;
            label_baza_dzien2.Visible = false;

            label_baza_nazwa.Text = "Wybierz użytkowwnika któremu chcesz przypisać dane";

            button3.Text = "Dodaj";

        }

        private void czyszczenie_baza()
        {
            comboBox_Bazy_Profil.Items.Clear();
            comboBox_day.Items.Clear();
            comboBox_month.Items.Clear();
            comboBox_year.Items.Clear();

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();


        }

        private void comboBox_Bazy_Profil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            comboBox_year.Items.Clear();
            comboBox_month.Items.Clear();
            comboBox_day.Items.Clear();

            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();

            String wypelnianie = "SELECT Rok FROM Dzien Where Nazwa = @Nazwa";

            SQLiteCommand Command = new SQLiteCommand(wypelnianie, databaseObject.Connection);
            databaseObject.openConnection();
            String  Name = comboBox_Bazy_Profil.Text;
            if(Combos_wybor == 2)
            {
                Name = comboBox1.Text;
            }
            Command.Parameters.AddWithValue("@Nazwa", Name);

            var reader = Command.ExecuteReader();

            databaseObject.openConnection();
            while (reader.Read())
            {
                if (!comboBox_year.Items.Contains(String.Format("{0}", reader[0])) || !comboBox2.Items.Contains(String.Format("{0}", reader[0])))
                {
                    comboBox2.Items.Add(String.Format("{0}", reader[0]));
                    comboBox_year.Items.Add(String.Format("{0}", reader[0]));
                    
                }
            }
            reader.Close();
            databaseObject.closeConnection();
            Command.Dispose();

        }

        private void comboBox_year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_month.Items.Clear();
            comboBox_day.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            String wypelnianie = "SELECT Miesiac FROM Dzien Where Nazwa = @Nazwa AND Rok = @Rok";

            SQLiteCommand Command = new SQLiteCommand(wypelnianie, databaseObject.Connection);
            databaseObject.openConnection();

            String Name = comboBox_Bazy_Profil.Text;
            String Rok = comboBox_year.Text;

            if (Combos_wybor == 2)
            {
                Name = comboBox1.Text;
                Rok = comboBox2.Text;
            }

            Command.Parameters.AddWithValue("@Nazwa", Name);
            Command.Parameters.AddWithValue("@Rok", Rok);
            var reader = Command.ExecuteReader();

            databaseObject.openConnection();
            while (reader.Read())
            {
                if (!comboBox_month.Items.Contains(String.Format("{0}", reader[0])) || !comboBox3.Items.Contains(String.Format("{0}", reader[0])))
                {
                    comboBox3.Items.Add(String.Format("{0}", reader[0]));
                    comboBox_month.Items.Add(String.Format("{0}", reader[0]));
                    
                }
                
            }
            reader.Close();
            databaseObject.closeConnection();
            Command.Dispose();
        }

        private void comboBox_month_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_day.Items.Clear();
            comboBox4.Items.Clear();
            String wypelnianie = "SELECT Numer FROM Dzien Where Nazwa = @Nazwa AND Rok = @Rok AND Miesiac = @Month";

            SQLiteCommand Command = new SQLiteCommand(wypelnianie, databaseObject.Connection);
            databaseObject.openConnection();

            String Name = comboBox_Bazy_Profil.Text;
            String Rok = comboBox_year.Text;
            String Month = comboBox_month.Text;

            if (Combos_wybor == 2)
            {
                Name = comboBox1.Text;
                Rok = comboBox2.Text;
                Month = comboBox3.Text;
            }

            Command.Parameters.AddWithValue("@Nazwa", Name);
            Command.Parameters.AddWithValue("@Rok", Rok);
            Command.Parameters.AddWithValue("@Month", Month);
            var reader = Command.ExecuteReader();

            databaseObject.openConnection();
            while (reader.Read())
            {
                if (!comboBox_day.Items.Contains(String.Format("{0}", reader[0])) || !comboBox4.Items.Contains(String.Format("{0}", reader[0])))
                {
                    comboBox_day.Items.Add(String.Format("{0}", reader[0]));
                    comboBox4.Items.Add(String.Format("{0}", reader[0]));
                }
            }
            reader.Close();
            databaseObject.closeConnection();
            Command.Dispose();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void But_Day_Click(object sender, EventArgs e)
        {
            czyszczenie_baza();
            combo_wypelnienie();
            panel3.Visible = true;
            Panel_Akcji_Profili.Visible = false;
            Panel_Akcji_Bazy.Visible = false;

           
            comboBox4.Visible = true;

            
            label11.Visible = true;


            Analiza_Wybor = 1;
            Combos_wybor = 2;

            chart1.Titles["Kroki"].Visible = false;
            chart1.Titles["Godzina"].Visible = false;
            chart1.Series["Kroki"].Points.Clear();

        }

        private void Wypelnij_Wykresy_Click(object sender, EventArgs e)
        {
            if(Analiza_Wybor == 1)
            {
                int kroki_dystans = 0;
                //chart1.Series.Clear();
                chart1.Series["Kroki"].Points.Clear();
                chart1.Titles["Kroki"].Visible = true;
                chart1.Titles["Godzina"].Visible = true;
                String dzien_znajdz1 = "SELECT IDD, Kroki FROM Dzien Where Nazwa = @Nazwa AND Numer = @Numer AND Miesiac = @Miesiac AND Rok = @Rok";
                String wypelnianie1 = "SELECT Pelna,Kwadrans,Polowa,trzykwadranse FROM Godzina Where IDD = @IDD";
               
                SQLiteCommand Command11 = new SQLiteCommand(dzien_znajdz1, databaseObject.Connection);
                databaseObject.openConnection();
                Command11.Parameters.AddWithValue("@Nazwa", comboBox1.Text);
                Command11.Parameters.AddWithValue("@Numer", comboBox4.Text);
                Command11.Parameters.AddWithValue("@Miesiac", comboBox3.Text);
                Command11.Parameters.AddWithValue("@Rok", comboBox2.Text);
                var reader11 = Command11.ExecuteReader();
                databaseObject.openConnection();
                String IDD = "1";
                while (reader11.Read())
                {
                    IDD = String.Format("{0}", reader11[0]);
                    kroki_dystans = toInt(String.Format("{0}", reader11[1]));
                }
                int iIDD = toInt(IDD);
                reader11.Close();
                databaseObject.closeConnection();
                Command11.Dispose();

                SQLiteCommand Command1 = new SQLiteCommand(wypelnianie1, databaseObject.Connection);//IDD200201026
                Command1.Parameters.AddWithValue("@IDD", IDD);
                databaseObject.openConnection();
                var reader = Command1.ExecuteReader();
                databaseObject.openConnection();
                double godz_kroki1 = 0;
                
                while (reader.Read())
                {

                    this.chart1.Series["Kroki"].Points.AddXY(godz_kroki1 + ":00", String.Format("{0}", reader[0]));
                    this.chart1.Series["Kroki"].Points.AddXY(godz_kroki1 + ":15", String.Format("{0}", reader[1]));
                    this.chart1.Series["Kroki"].Points.AddXY(godz_kroki1 + ":30", String.Format("{0}", reader[2]));
                    this.chart1.Series["Kroki"].Points.AddXY(godz_kroki1 + ":45", String.Format("{0}", reader[3]));
                    godz_kroki1++;
                }

                //chart1.Series["Kroki"].Points[50].Color = Color.Red;
                //chart1.Series["Kroki"].Points[10].Color = System.Drawing.Color.Black;

                //chart1.Series["Kroki"].IsValueShownAsLabel = true;
                reader.Close();
                databaseObject.closeConnection();
                Command1.Dispose();
                this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm";
                chart1.ChartAreas[0].AxisX.Interval = 4;



                




                String dlugosc_kroku = "SELECT Kroki FROM Profil Where Nazwa = @Nazwa";
                SQLiteCommand Command111 = new SQLiteCommand(dlugosc_kroku, databaseObject.Connection);
                Command111.Parameters.AddWithValue("@Nazwa", comboBox1.Text);
                databaseObject.openConnection();
                var reader111 = Command111.ExecuteReader();
                String dlugosc ="";
                while (reader111.Read())
                {
                    dlugosc = String.Format("{0}", reader111[0]);
                    
                }
                reader111.Close();
                databaseObject.closeConnection();
                Command1.Dispose();
                int odleglosc = kroki_dystans * toInt(dlugosc);
                odleglosc = odleglosc / 100;
                textBox1.Text = odleglosc.ToString();
                double kalorie = kroki_dystans * 0.04;
                textBox2.Text = kalorie.ToString();
            }
            else if(Analiza_Wybor == 2)
            {
                //chart1.Series.Clear();
                chart1.Series["Kroki"].Points.Clear();
                String wypelnianie1 = "SELECT Numer,Kroki FROM Dzien Where Nazwa = @Nazwa AND Miesiac = @Miesiac AND Rok = @Rok";
                SQLiteCommand Command1 = new SQLiteCommand(wypelnianie1, databaseObject.Connection);//IDD200201026
                databaseObject.openConnection();

                String IDD = "200201026";
                String Profil = "Test";
                String Miesiac = "1";
                String Rok = "2021";
                int kroki_dystans = 0;
                Command1.Parameters.AddWithValue("@Nazwa", comboBox1.Text);
                Command1.Parameters.AddWithValue("@Miesiac", comboBox3.Text);
                Command1.Parameters.AddWithValue("@Rok", comboBox2.Text);
                var reader = Command1.ExecuteReader();
                databaseObject.openConnection();
                double godz_kroki1 = 0;
                while (reader.Read())
                {

                    this.chart1.Series["Kroki"].Points.AddXY(String.Format("{0}", reader[0]), String.Format("{0}", reader[1]));
                    kroki_dystans += toInt(String.Format("{0}", reader[1]));
                    godz_kroki1++;
                }
                //chart1.Series["Kroki"].Points[50].Color = Color.Red;
                //chart1.Series["Kroki"].Points[10].Color = System.Drawing.Color.Black;

                //chart1.Series["Kroki"].IsValueShownAsLabel = true;
                reader.Close();
                databaseObject.closeConnection();
                Command1.Dispose();
                this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd";
                chart1.ChartAreas[0].AxisX.Interval = 1;


                String dlugosc_kroku = "SELECT Kroki FROM Profil Where Nazwa = @Nazwa";
                SQLiteCommand Command111 = new SQLiteCommand(dlugosc_kroku, databaseObject.Connection);
                Command111.Parameters.AddWithValue("@Nazwa", comboBox1.Text);
                databaseObject.openConnection();
                var reader111 = Command111.ExecuteReader();
                String dlugosc = "";
                while (reader111.Read())
                {
                    dlugosc = String.Format("{0}", reader111[0]);

                }
                reader111.Close();
                databaseObject.closeConnection();
                Command1.Dispose();
                int odleglosc = kroki_dystans * toInt(dlugosc);
                odleglosc = odleglosc / 100;
                textBox1.Text = odleglosc.ToString();
                double kalorie = kroki_dystans * 0.04;
                textBox2.Text = kalorie.ToString();
            }
        }
            

        private void But_Month_Click(object sender, EventArgs e)
        {
            czyszczenie_baza();
            combo_wypelnienie();
            panel3.Visible = true;
            Panel_Akcji_Profili.Visible = false;
            Panel_Akcji_Bazy.Visible = false;

            
            comboBox4.Visible = false;

            
            label11.Visible = false;

            Analiza_Wybor = 2;
            Combos_wybor = 2;

            chart1.Titles["Kroki"].Visible = false;
            chart1.Titles["Godzina"].Visible = false;
            chart1.Series["Kroki"].Points.Clear();
        }

        private void textBox_Tylko_Liczby_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void Liczby_Wykres_Click(object sender, EventArgs e)
        {
            if(chart1.Series["Kroki"].IsValueShownAsLabel == false)
            {
                chart1.Series["Kroki"].IsValueShownAsLabel = true;
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType chart = 0;
                chart1.Series["Kroki"].ChartType = chart; 
            }
            else if (chart1.Series["Kroki"].IsValueShownAsLabel == true)
            {
                chart1.Series["Kroki"].IsValueShownAsLabel = false;
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType chart2 = (System.Windows.Forms.DataVisualization.Charting.SeriesChartType)3;
                chart1.Series["Kroki"].ChartType = chart2;
            }

        }
    }
}
