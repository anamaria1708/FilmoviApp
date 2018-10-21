using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace FilmoviApp
{
    public partial class Form_ADD : Form
    {
        
        private DataSet ds = new DataSet(); //podaci o kojoj tablici i podatke iz te tablice..
        private DataTable dt = new DataTable(); //klasa tablica
        public Form_ADD()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.backgorundd_picture;
            this.FormBorderStyle = FormBorderStyle.None; //remove any border
            //this.TopMost = true;                        //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fulscreen
        }

        private void Form_ADD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            NpgsqlConnection connection = new NpgsqlConnection();//stvaram "prazan" objekt

            try
            {
                string connectionstring;
                Form2.GetConnection(out connection, out connectionstring);
                string sql1 = "select MAX(movieid) from movie";
                
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql1, connectionstring); //PRICA S BAZOM


                ds.Reset(); // data set ono sta vrati baza
                da.Fill(ds); //data adapter napuni data set; a data table je jedna od tih
                dt = ds.Tables[0];
                int newId = (int)dt.Rows[0].ItemArray[0];
                newId++;
         

                string sql2 = "   INSERT INTO movie(movieid,title,categories,summary,description)" +
               "                  values (" + newId+ ","+"'"+ titlebox.Text + "'"  + "," + "'" + categoriesbox.Text + "'" + "," + "'" + summarybox.Text + "'" +
                                      "," + "'" + descriptionbox.Text + "'" + ")   " ; 

                da = new NpgsqlDataAdapter(sql2, connectionstring);

                ds.Reset();
                da.Fill(ds);

                //dt = ds.Tables[0];

            }
            catch (Exception k)
            {
                k.StackTrace.ToString(); //pokazivat ce tocno di je greska i ispisat koja je, opis greske
            }

            finally
            {
                connection.Close();
                MessageBox.Show("Uspjesno dodan film :) ");
                titlebox.ResetText();
                categoriesbox.ResetText();
                summarybox.ResetText();
                descriptionbox.ResetText();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
