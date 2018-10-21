using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace FilmoviApp
{
    public partial class Form_ANALIZA : Form
    {
        private DataSet ds = new DataSet(); //podaci o kojoj tablici i podatke iz te tablice..
        private DataTable dt = new DataTable(); //klasa tablica

        string poDanimaSTART;
        string poDanimaFINISH;
        string poSatima;
       
        public Form_ANALIZA()
        {
            InitializeComponent();
        }

        private void Form_ANALIZA_Load(object sender, EventArgs e)
        {

            this.BackgroundImage = Properties.Resources.backgorundd_picture;
            this.FormBorderStyle = FormBorderStyle.None; //remove any border
            //this.TopMost = true;                        //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fulscreen

            analizaGrid.AutoGenerateColumns = false;

            radioButtonPODANIMA.Checked = true;
            dateTimePickerDAYSTART.Format = DateTimePickerFormat.Short;
            dateTimePickerDAYFINISH.Format = DateTimePickerFormat.Short;
       

        }



        private void buttonANALIZIRAJ_Click(object sender, EventArgs e)
        {
            string upit = "";
            string podupit = "";

            string upit2 = "";
            string podupit2 = "";



            //Regex ZamjeniTocku = new Regex(@"\."); //tocka oznavama bilo koji znak, ne treba jer cemo Replace

            if (dateTimePickerDAYSTART.Value < dateTimePickerDAYFINISH.Value)
            {
                if (radioButtonPODANIMA.Checked)
                {

                    poDanimaSTART = dateTimePickerDAYSTART.Text;     
                    poDanimaFINISH = dateTimePickerDAYFINISH.Text;

                    poDanimaFINISH = poDanimaFINISH.Replace('.', '-'); //zamjena . sa -
                    poDanimaSTART = poDanimaSTART.Replace('.', '-');

                    poDanimaFINISH = poDanimaFINISH.Remove(poDanimaFINISH.Length - 1);//maknit zadnju -
                    poDanimaSTART = poDanimaSTART.Remove(poDanimaSTART.Length - 1);

                    NpgsqlConnection connection = new NpgsqlConnection();//stvaram "prazan" objekt

                    //moram CASTAT vrijeme unosa zato sto vrijeme_unosa je date time, a nas zanima samo date
                    //radimo string koji saljemo u bazu:
                    //gdje datum odgovara nekom periodu i grupiram po tome koji je zahrjev i po datumu
                    // PIVOTINANJE: biramo sta zelimo da bude redak, a sta da bude stupac
                    // grupiranje podataka po vise kriterija, tj sazeti prikaz podataka
                    //za pivotiranje moramo mapravit sljedeci podupit:
                    try
                    {
                        string connectionstring;
                        Form2.GetConnection(out connection, out connectionstring);

                        podupit= @"SELECT unos_korisnika, 
                        CAST(""vrijeme_unosa"" AS date) AS vrijeme, 
	                    CAST(COUNT(*) AS integer) AS broj_unosa
                        FROM queryhistory
                        WHERE CAST(""vrijeme_unosa"" AS DATE) BETWEEN '" + poDanimaSTART + "' AND '" + poDanimaFINISH + @"'
                        GROUP BY unos_korisnika, vrijeme
                        ORDER BY Unos_korisnika, vrijeme";

                        // json_object_agg definirat: stupce u pivotiranju; on ce uzet datume i koliko ih ima i 
                        upit = @"SELECT unos_korisnika,
                        json_object_agg(vrijeme, broj_unosa ORDER BY vrijeme) AS datumi
                        FROM (" + podupit + @") podupiit
                        GROUP BY unos_korisnika
                        ORDER BY unos_korisnika";

                        //@ moram koristit da mi npr za \n ne stavlja novi red nego bas uzme \n

                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(upit, connectionstring); //PRICA S BAZOM

                        ds.Reset(); // data set ono sta vrati baza
                        analizaGrid.DataSource = null; //resetirat data source za svaki slucaj
                        analizaGrid.AutoGenerateColumns = true; //ne zelimo da sam generira stupce nego cemo ih mi postavit
                        //foreach(in ds.Tables[0])

                        da.Fill(ds); //data adapter napuni data set; a data table je jedna od tih
                        dt = ds.Tables[0];
                    //    dt.Columns[1].
                        analizaGrid.DataSource = dt;


                    }
                    catch (Exception k)
                    {
                        k.StackTrace.ToString(); //pokazivat ce tocno di je greska i ispisat koja je, opis greske

                    }

                    finally
                    {
                        connection.Close();

                    }


                }

                else if (radioButtonPOSATIMA.Checked)
                {
                    poDanimaSTART = dateTimePickerDAYSTART.Text;
                    poDanimaFINISH = dateTimePickerDAYFINISH.Text;

                    poDanimaFINISH = poDanimaFINISH.Replace('.', '-'); //zamjena . sa -
                    poDanimaSTART = poDanimaSTART.Replace('.', '-');

                    poDanimaFINISH = poDanimaFINISH.Remove(poDanimaFINISH.Length - 1);//maknit zadnju -
                    poDanimaSTART = poDanimaSTART.Remove(poDanimaSTART.Length - 1);

                    NpgsqlConnection connection = new NpgsqlConnection();//stvaram "prazan" objekt

                    //moram CASTAT vrijeme unosa zato sto vrijeme_unosa je date time, a nas zanima samo date
                    //radimo string koji saljemo u bazu:
                    //gdje datum odgovara nekom periodu i grupiram po tome koji je zahrjev i po datumu
                    // PIVOTINANJE: biramo sta zelimo da bude redak, a sta da bude stupac
                    // grupiranje podataka po vise kriterija, tj sazeti prikaz podataka
                    //za pivotiranje moramo mapravit sljedeci podupit:
                    try
                    {
                        string connectionstring;
                        Form2.GetConnection(out connection, out connectionstring);

                        podupit2 = @"select unos_korisnika, 
                        EXTRACT(HOUR FROM ""vrijeme_unosa"") AS vrijeme,
                        CAST(COUNT(*) AS integer) AS broj_unosa
                        FROM queryhistory
                        WHERE CAST(""vrijeme_unosa"" AS DATE) BETWEEN '" + poDanimaSTART + "' AND '" + poDanimaFINISH + @"'
                        GROUP BY unos_korisnika, vrijeme
                        ORDER BY unos_korisnika, vrijeme";

                        // json_object_agg definirat: stupce u pivotiranju; on ce uzet datume i koliko ih ima i 
                        upit2 = @"SELECT unos_korisnika,
                        json_object_agg(vrijeme, broj_unosa ORDER BY vrijeme) AS datumi
                        FROM (" + podupit2 + @") podupit2
                        GROUP BY unos_korisnika
                        ORDER BY unos_korisnika";

                        //@ moram koristit da mi npr za \n ne stavlja novi red nego bas uzme \n

                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(upit, connectionstring); //PRICA S BAZOM

                        ds.Reset(); // data set ono sta vrati baza
                        da.Fill(ds); //data adapter napuni data set; a data table je jedna od tih
                        dt = ds.Tables[0];
                        analizaGrid.DataSource = dt;


                    }
                    catch (Exception k)
                    {
                        k.StackTrace.ToString(); //pokazivat ce tocno di je greska i ispisat koja je, opis greske

                    }

                    finally
                    {
                        connection.Close();

                    }



                }
            }

            else
            {
                MessageBox.Show("ERROR! Datum neispravan!");
            }

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
