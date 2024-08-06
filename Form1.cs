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
using Oracle.ManagedDataAccess.Client;
using System.Data;



namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        /*
        void Hasta_Gir()
        {
            baglanti = new SqlConnection("server=localhost;Initial Catolog=XE; Integrated Security=TRUE");       

            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM HASTA", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        */
        private void Hasta_Kayıt_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Hasta_Listele_Click(object sender, EventArgs e)
        {
            try
            {
                Connection db = new Connection();
                db.DB();
           
                using (db.con)
                {

                    OracleCommand cmd = new OracleCommand("SELECT *FROM KULLANICI", db.con);
                    OracleDataAdapter oda = new OracleDataAdapter(cmd);
                    DataTable data = new DataTable();
                    
                    oda.Fill(data);
                    dataGridView1.DataSource = data;
                    MessageBox.Show("Listeleme tamamlanmıştır");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
