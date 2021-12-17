using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Domaci_Lola_Curic_forma
{
    public partial class Form1 : Form
    {
        string CS = @"Data source=DESKTOP-1NL18RV\SQLEXPRESS; Initial catalog=oblici; Integrated security=True ";
        DataTable podaci = new DataTable();
        int red = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM figura", veza);
            adapter.Fill(podaci);
            reload();
        }

        private void reload()
        {
            if (podaci.Rows.Count==0)
            {
                txt_ID.Text = "";
                txt_naziv.Text = "";
                txt_brtem.Text = "";
                txt_forpov.Text = "";
                txt_forob.Text = "";
                napred.Enabled = false;
                nazad.Enabled = false;
                kraj.Enabled = false;
                pocetak.Enabled = false;
                red = 0;
                brisi.Enabled = false;
                izmeni.Enabled = false;
            }
            else
            {
                txt_ID.Text = podaci.Rows[red]["id"].ToString();
                txt_naziv.Text = podaci.Rows[red]["naziv"].ToString();
                txt_brtem.Text = podaci.Rows[red]["br_temena"].ToString();
                txt_forpov.Text = podaci.Rows[red]["for_pov"].ToString();
                txt_forob.Text = podaci.Rows[0]["for_ob"].ToString();
                napred.Enabled = (red != podaci.Rows.Count - 1);
                kraj.Enabled = (red != podaci.Rows.Count - 1);
                nazad.Enabled = (red != 0);
                pocetak.Enabled = (red != 0);
            }
        }

        private void napred_Click(object sender, EventArgs e)
        {
            red++;
            reload();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            red--;
            reload();
        }

        private void kraj_Click(object sender, EventArgs e)
        {
            red = podaci.Rows.Count - 1;
            reload();
        }

        private void pocetak_Click(object sender, EventArgs e)
        {
            red = 0;
            reload();
        }

        private void brisi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand("DELETE FROM figura WHERE id=" + txt_ID.Text, veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM figura", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            if (red > podaci.Rows.Count - 1)
                red = podaci.Rows.Count - 1;
            reload();
        }

        private void izmeni_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand("UPDATE figura SET naziv='" + txt_naziv.Text + "', br_temena=" + txt_brtem.Text + ", for_pov='" + txt_forpov.Text + "', for_ob='"+txt_forob.Text+"' where id=" + txt_ID.Text, veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM figura", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            if (red > podaci.Rows.Count - 1)
                red = podaci.Rows.Count - 1;
            reload();
        }

        private void unesi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand("INSERT INTO figura(naziv,br_temena,for_pov,for_ob) VALUES ('"+ txt_naziv.Text +"'," + txt_brtem.Text + ",'"+ txt_forpov.Text + "','" + txt_forob.Text + "')" , veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM figura", veza);
            podaci.Clear();
            adapter.Fill(podaci);
                red = podaci.Rows.Count - 1;
            reload();
        }
    }
}
