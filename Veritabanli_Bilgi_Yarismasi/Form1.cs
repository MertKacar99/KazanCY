using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabanli_Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void levelControl()
        {
            if (btnlevel1.BackColor == Color.Green)
            {
                lblseviyeKontrol.Text = "2";

            }
            else if (btnlevel1.BackColor == Color.Green && btnlevel2.BackColor == Color.Green)
            {
                lblseviyeKontrol.Text = "3";
            }
            else
            {
                lblseviyeKontrol.Text = "1";
            }
        }

        SqlConnection connection = new SqlConnection (@"Data Source=MERT;Initial Catalog=DB_Bilgiyarismasi;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
                 
            levelControl();
            btnlevel2.Enabled = false;
            btnlevel3.Enabled = false;
          
        }

        //Soruları Çekme İşlemi
        public void getQuestion1()
        {
            //Bağlantı açıldı.  
            connection.Open();
            SqlCommand level1Get = new SqlCommand("SELECT TOP 1 * FROM tblSorular  where seviye=1  ORDER BY NEWID()", connection);
            SqlDataReader sqldata = level1Get.ExecuteReader();
            while (sqldata.Read())
            {
                richtextboxsoru.Text = sqldata[2].ToString();
                btnlevel1.Enabled = false;
                lblId.Text = sqldata[3].ToString();
                lblId.Visible = false;
                
            }
            connection.Close();
        }
        public void getQuestion2()
        {
            //Bağlantı açıldı.  
            connection.Open();
            SqlCommand level1Get = new SqlCommand("SELECT TOP 1 * FROM tblSorular  where seviye=2  ORDER BY NEWID()", connection);
            SqlDataReader sqldata = level1Get.ExecuteReader();
            while (sqldata.Read())
            {
                richtextboxsoru.Text = sqldata[2].ToString();
                btnlevel2.Enabled = false;
                lblId.Text = sqldata[3].ToString();
                lblId.Visible = false;
            }
            connection.Close();
        }
        public void getQuestion3()
        {
            //Bağlantı açıldı.  
            connection.Open();
            SqlCommand level1Get = new SqlCommand("SELECT TOP 1 * FROM tblSorular  where seviye=3  ORDER BY NEWID()", connection);
            SqlDataReader sqldata = level1Get.ExecuteReader();
            while (sqldata.Read())
            {
                richtextboxsoru.Text = sqldata[2].ToString();
                btnlevel3.Enabled = false;
                lblId.Text = sqldata[3].ToString();
                lblId.Visible = false;
            }
            connection.Close();
        }



        private void btnlevel1_Click(object sender, EventArgs e)
        {
            getQuestion1();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text ==  lblId.Text)
            {
                if(lblseviyeKontrol.Text == "1")
                {
                    btnlevel1.BackColor = Color.Green;
                    btnlevel2.Enabled = true;
                    btnlevel2.PerformClick();
                    textBox1.Clear();
                    levelControl(); 
               
                 
                }
                else if (lblseviyeKontrol.Text == "2")
                {
                    btnlevel2.BackColor = Color.Green;
                    btnlevel3.Enabled = true;
                    btnlevel3.PerformClick();
                    textBox1.Clear();
                    levelControl();
                  
                }
                else if (lblseviyeKontrol.Text == "3")
                {
                    btnlevel2.BackColor = Color.Green;
                    btnlevel3.Enabled = true;
                    btnlevel3.PerformClick();
                    textBox1.Clear();
                    levelControl();

                }
            }
            else 
            {
                
            }
           
            
        }
        private void btnlevel2_Click(object sender, EventArgs e)
        {
            getQuestion2();
            
        }

        private void btnlevel3_Click(object sender, EventArgs e)
        {
            getQuestion3();
        }
    }
}
