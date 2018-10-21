using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace FilmoviApp
{
    public partial class Form_SEARCH : Form
    {
        private DataSet ds = new DataSet(); //podaci o kojoj tablici i podatke iz te tablice..
        private DataTable dt = new DataTable(); //klasa tablica
        string operacija;
        public Form_SEARCH()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.backgorundd_picture;
            // player.URL = "musicmp3.mp3";
            // player.controls.play();
           


            //this.FormBorderStyle = FormBorderStyle.None; //remove any border
            //this.TopMost = true;                        //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fulscreen

        }

        private void Form_SEARCH_Load(object sender, EventArgs e)
        {
            NpgsqlConnection connection = new NpgsqlConnection();//stvaram "prazan" objekt

            try
            {
                string connectionstring;
                Form2.GetConnection(out connection, out connectionstring);
                string sql = "SELECT rijec from rijeci";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, connectionstring); //PRICA S BAZOM

                ds.Reset(); // data set ono sta vrati baza, tj pomocu da to spremimo u ds (mozemo imat i vise tablica za vratit (union)
                da.Fill(ds); //data adapter napuni data set
                dt = ds.Tables[0]; //u dt spremimo jednu od tablica koja je vracena koja nam treba

                List<string> s = new List<string>();

                //foreach(string zapis in s)
                //{
                //    //uzima varijablu iz s i stavlja je u zapis...... i radimo s njom sta radimo
                //}

                foreach (DataRow row in dt.Rows) // 
                {
                    s.Add(row.ItemArray.FirstOrDefault().ToString());
                }


                var source = new AutoCompleteStringCollection();
                source.AddRange(s.ToArray()); // dodaje u source kolekciju stringova;
                //da ne moram pisat 74 puta source.ADD(s.ToArray[0])...
                //ToArray da mi bude niz
                textBox1.AutoCompleteCustomSource = source; //pridruzila mu source
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //stavili mu da mu je mod predlozi kraj
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; //da koristi customsource koji smo mi napravili; po nasoj mjeri

                textBox_SQLQUERY.Enabled = false; //da je samo read only

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

        private void button_search_Click(object sender, EventArgs e)
        {
            
            if (radiobuttonAND.Checked)
            {
                operacija = " & ";
            }

            else if (radiobuttonOR.Checked)
            {
                operacija = " | ";
            }

            else
            {
                operacija = "";
            }

            /// konecija na bazu
            /// 
            NpgsqlConnection connection = new NpgsqlConnection();

            // prirema query stringa za sql pretragu

            string priprema = textBox1.Text; //povuc cu sa inputa sta je upisano

            Regex RegexZaUzorak = new Regex("\\\".+?\\\""); // . zamjenjuje bilo koji znak, + jedan ili vise puta taj znak, a ? uzmi najmanje sto mozes
            Regex RegexZaUzorak2 = new Regex("\\\""); // \\ escepea jedan \, a \" escepa navodni znak, tj trazim \"
          //  Regex RegexZaUzorak3 = new Regex("\\(.+?\\)"); // moramo ovako dodat \ jer mi () znaci grupiranje u regularnim izrazima; zapravo radi isto sta i regex1 samo gleda ( umjesto "


            MatchCollection matches = RegexZaUzorak2.Matches(priprema); //pokusava naci podudaranje zadanog uzorka u zadanom stringu po \navodnim znakovima
            
            var a = RegexZaUzorak.Split(priprema); //sprema niz svih koji nisu uzorak

            foreach(string q in a) //u pripremi trazimo a i ako ga najdejmo, a on nije prazno mjesto ili " " makni ga iz pripreme da ostanu samo fraze
            {
             if(!String.IsNullOrWhiteSpace(q) && !String.IsNullOrEmpty(q))
                {
                    priprema = priprema.Remove(priprema.IndexOf(q), q.Length); //u pripremi mi je uzorak, tj ono s " "
                }
            }

            for (int i = 0, k = matches.Count / 2; i < k; ++i) //minjamo navodne znake sa odgovarajucim zagradama jer takva je sintaksa za postgre bazu                                                     
            {
                priprema = RegexZaUzorak2.Replace(priprema, "(", 1); //1 jer ce samo prvo pojabvljivanje zamijenit
                priprema= RegexZaUzorak2.Replace(priprema, ")", 1);
            }
            
            // u a smo dobili samo normalne
            //u priprema smo dobili fraze


            string[] pripremapolje = priprema.Split(')'); //splitanje fraze po zagradama

            List<string> lista = pripremapolje.ToList(); //privremena lista
            List<string> nonullLista = new List<string>(); //lista fraza sa pripadajucim zagradama; morali stvorit novu jer ne mozemo po listi hodat i mijenjat podatke
            lista.ForEach(item => {
                if (!String.IsNullOrEmpty(item) && !String.IsNullOrWhiteSpace(item))
                    nonullLista.Add(item +")"); //spremit samo ne nul podatke jer smo ih gore imali i dodat )
                    });

            lista = a.ToList();
     
            List<string> nonNull2 = new List<string>();
            lista.ForEach(item => {
                if (!String.IsNullOrEmpty(item ) && !String.IsNullOrWhiteSpace(item))
                    nonNull2.Add(item); //isto za ne nul podatke i za ne-fraze
            });

            string toRet2 = "";
            toRet2 += String.Join(operacija, nonNull2.ToArray()); //spajanje ne-fraze s operatorom


            string toRet = "";
            nonullLista.ForEach(item => toRet += String.Join(" & ", item.Split(' '))); //spajanje fraze s 
            int o = 0;
            int z = 0;
            StringBuilder sb = new StringBuilder(); //stvara stringove od charactera

            foreach (char c in toRet)
            {
                if (c == '(')
                {
                    ++o;
                }
                if(c ==')')
                {
                    ++z;
                }
                if (c=='&' && (o==z))
                {
                    sb.Append(operacija);
                    continue;
                }

                sb.Append(c);
            }
            toRet = sb.ToString();

            //string[] pripremapolje = priprema.Split(' '); //razdvojit po razmacima, ali paziti ako imam frazu (prvo po regexima pa onda splita
            priprema = String.Join(operacija, pripremapolje);//doslovno izmedu svakog u polju ubacuje operator

                toRet2 = toRet2 + operacija + toRet;

            try
            {
                string connectionstring;
                Form2.GetConnection(out connection, out connectionstring);
                string sql = String.Format("SELECT m.movieid, m.title," +
                    " ts_headline(m.title, to_tsquery('english', '{0}')) AS \"TITLE\"," +
                    " ts_headline(m.description, to_tsquery('english', '{0}')) AS \"DESCRIPTION\", " +
                    "m.description, " +
                    "ts_rank(m.sumtsvector, to_tsquery('english', '{0}'), 1) AS \"RANG\"" +
                    "\r\nFROM movie AS m\r\n" +
                    "WHERE (m.sumtsvector @@ to_tsquery('{0}')) = TRUE\r\n" +
                    "ORDER BY \"RANG\" DESC",toRet2);

                //'{0}' ko %d, a da imamo vise parametara onda povecavam broj

                textBox_SQLQUERY.Text = sql;

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, connectionstring); //PRICA S BAZOM

                ds.Reset(); // data set ono sta vrati baza, tj pomocu da to spremimo u ds (mozemo imat i vise tablica za vratit (union)
                da.Fill(ds); //data adapter napuni data set
                dt = ds.Tables[0]; //u dt spremimo jednu od tablica koja je vracena koja nam treba

                dataGridView_documentsRang.DataSource = dt; //.DataSource je izvor podataka za taj je u dt
                dataGridView_documentsRang.Columns["movieid"].Visible = false;

                label_count.Text = dt.Rows.Count.ToString();

                //za insert u queryhstory
                string sql2 = string.Format("INSERT INTO queryhistory(unos_korisnika,vrijeme_unosa)" +
                    "                       VALUES ('{0}' , '{1}')", toRet2, DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));

                da = new NpgsqlDataAdapter(sql2, connectionstring); //PRICA S BAZOM

                ds.Reset(); // data set ono sta vrati baza, tj pomocu da to spremimo u ds (mozemo imat i vise tablica za vratit (union)
                da.Fill(ds); //data adapter napuni data set


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

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
