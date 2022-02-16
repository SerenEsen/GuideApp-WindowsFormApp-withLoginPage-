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
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8Q26SJ2\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        void BringPerson()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM dbo.Persons", connection);
            DataTable table = new DataTable();//Çekilen verilerin gösterimi dataset ile de yapılabilir.
            da.Fill(table);//da aracılığı ile alınan kişileri tabloya aktarma işlemi.
            dgv.DataSource = table;//Datagridviewe tabloyu aktarma işlemi.
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sv_btn_Click(object sender, EventArgs e)
        {
            
            string add = "INSERT INTO dbo.Persons(Name,Surname,Phone_number) VALUES (@Name,@Surname,@Phone_number)";
            SqlCommand command = new SqlCommand(add, connection);
            command.Parameters.AddWithValue("@Id", id_txt.Text);//ID kısmına girilen değer önce command değişkenine gidecek. cammand değişkeni onu add stringine verecek.Daha sonra veritabanındaki Id değişkenine verilmiş olacak.
            command.Parameters.AddWithValue("@Name", name_txt.Text);
            command.Parameters.AddWithValue("@Surname", surname_txt.Text);
            command.Parameters.AddWithValue("@Phone_number", phone_txt.Text);

            connection.Open();
            command.ExecuteNonQuery();//Bağlantı açıldıktan sonra oluşturullan komutun çalışmasını sağlar.
            connection.Close();//Burda sadece ekler ama biz göremeyiz.
            BringPerson();//Bu metod yardımı ile eklenen dahiil tüm kişiler görünebilir.

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            BringPerson();

        }

        private void del_txt_Click(object sender, EventArgs e)
        {
            string del = "DELETE FROM dbo.Persons WHERE Id=@Id";
            SqlCommand command = new SqlCommand(del, connection);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(id_txt.Text)); //Bu kısım seçilen satırın tamamen silinmesini sağlar.   
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            BringPerson();
        }

        private void upd_txt_Click(object sender, EventArgs e)
        {
            string update = "UPDATE dbo.Persons SET Name=@Name,Surname=@Surname,Phone_number=@Phone_number WHERE Id=@Id";
            SqlCommand command = new SqlCommand(update, connection);
            command.Parameters.AddWithValue("@Id", dgv.CurrentRow.Cells[0].Value);
            command.Parameters.AddWithValue("@Name", name_txt.Text);
            command.Parameters.AddWithValue("@Surname", surname_txt.Text);
            command.Parameters.AddWithValue("@Phone_number", phone_txt.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            BringPerson();
        }
     

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Current cell e bir datagridview ve da ya bağlı olduğunda izin verilir.
            id_txt.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            name_txt.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            surname_txt.Text = dgv.CurrentRow.Cells[2].Value.ToString();
            phone_txt.Text = dgv.CurrentRow.Cells[3].Value.ToString();
            //Bu işlemlerden sonra datagridviewda enable özellikleri kaldırılarak değişiklik yapması engellenebilir.

        }
    }
}
