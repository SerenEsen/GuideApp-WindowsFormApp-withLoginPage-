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

namespace Login_APP
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8Q26SJ2\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                string query = "SELECT * FROM dbo.Admin_Users WHERE Registration_num=@Registration_num AND Password=@Password";
                //Şimdi parametreleri oluşturmam gerekiyor.
                SqlParameter prm1 = new SqlParameter("Registration_num", reg_txt.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Password", pass_txt.Text.Trim());
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(prm1);//oluşturulan komuta parametrelerin eklenmesi.
                command.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);

                if (dt.Rows.Count > 0)//Textbox içerisine girilen değerlerin doğruluğu kontrol eder.
                {
                    Form2 fr = new Form2();
                    fr.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Try Again!");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();

        }
    }
}
