using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_APP
{
    public partial class Form3 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8Q26SJ2\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void sign_btn_Click(object sender, EventArgs e)
        {
            string add = "INSERT INTO LOGIN.dbo.Admin_Users(Registration_num,Password) VALUES (@Registration_num,@Password)";
            SqlCommand command = new SqlCommand(add, connection);
            command.Parameters.AddWithValue("@Registration_num", sign_reg_txt.Text);
            command.Parameters.AddWithValue("@Password", sign_pas_txt.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
