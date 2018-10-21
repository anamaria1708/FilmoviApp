using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Npgsql;

namespace FilmoviApp
{
    public partial class Form2 : Form
    {

        private DataSet ds = new DataSet(); //podaci o kojoj tablici i podatke iz te tablice..
        private DataTable dt = new DataTable(); //klasa tablica
        public Form2()
        {
            InitializeComponent();


            this.BackgroundImage = Properties.Resources.backgorundd_picture;
            // player.URL = "musicmp3.mp3";
            // player.controls.play();
            //Player1.Visible = false;


            this.FormBorderStyle = FormBorderStyle.None; //remove any border
            this.TopMost = true;                        //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fulscreen

            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string upit = "SELECT * from movie";
            IzvrsiUpit(upit,ds,dt);
        }

        public void IzvrsiUpit(string upit, DataSet ds, DataTable dt)
        {
            NpgsqlConnection connection = new NpgsqlConnection();//stvaram "prazan" objekt

            try
            {
                string connectionstring;
                GetConnection(out connection, out connectionstring);
                string sql = upit;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, connectionstring); //PRICA S BAZOM

                ds.Reset(); // data set ono sta vrati baza
                da.Fill(ds); //data adapter napuni data set; a data table je jedna od tih
                dt = ds.Tables[0];
                dataGridView1.DataSource = dt;


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

        public static void GetConnection(out NpgsqlConnection connection, out string connectionstring)
        {
            connectionstring = string.Format("Server={0};Port={1};" +
                                "User Id={2}; Password={3};Database={4};", "localhost",
                                "5432", "postgres", "Jq72973I", "postgres");
            connection = new NpgsqlConnection(connectionstring);
            connection.Open();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
