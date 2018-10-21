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
using Npgsql; //ukjucila ono sta sam instalirala

namespace FilmoviApp
{
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet(); //podaci o kojoj tablici i podatke iz te tablice..
        private DataTable dt = new DataTable(); //klasa tablica
                                                // WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Form1()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.backgorundd_picture;
           // player.URL = "musicmp3.mp3";
           // player.controls.play();
            Player1.Visible= false;
            

            this.FormBorderStyle = FormBorderStyle.None; //remove any border
            this.TopMost = true;                        //Bring the form to the front
            this.Bounds = Screen.PrimaryScreen.Bounds;  //Make it fulscreen

            button1.BackColor= System.Drawing.Color.Transparent; 
            menulabel.BackColor = System.Drawing.Color.Transparent;

        }

        private void allmovies_button_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(); //stvorila novi objket klase form2
            this.Hide();
            form.ShowDialog();//neka mi se ta forma pokaze
            this.Show();

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Form_ADD form = new Form_ADD();
            this.Hide();
            form.ShowDialog();
            this.Show();

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            Form_SEARCH form = new Form_SEARCH();
            this.Hide();
            form.ShowDialog();
            this.Show();

        }
    }
}
