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
using System.Data.OleDb;


namespace guide_app
{
    public partial class Form1 : Form
    {
     
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }
        void BringPerson()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-8Q26SJ2\SQLEXPRESS;Initial Catalog=dbREHBER;Integrated Security=True");
            connection.Open();
            da = new SqlDataAdapter("SELECT *FROM Persons", connection);
            DataTable table = new DataTable();//Çekilen verilerin gösterimi dataset ile de yapılabilir.
            da.Fill(table);//da aracılığı ile alınan kişileri tabloya aktarma işlemi.
            persons_dgv.DataSource = table;//Datagridviewe tabloyu aktarma işlemi.
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BringPerson();
        }
        private void save_btn_Click(object sender, EventArgs e)//Bu metot kişileri database e kaydetmeyi sağlayacak metottur.
        {
            string add = "INSERT INTO dbREHBER.dbo.Persons(Id,Name,Surname,Phone_number) VALUES (@Id,@Name,@Surname,@Phone_number)";
            command = new SqlCommand(add, connection);
            command.Parameters.AddWithValue("@Id", ıd_txt.Text);//ID kısmına girilen değer önce command değişkenine gidecek. cammand değişkeni onu add stringine verecek.Daha sonra veritabanındaki Id değişkenine verilmiş olacak.
            command.Parameters.AddWithValue("@Name", name_txt.Text);
            command.Parameters.AddWithValue("@Surname", surname_txt.Text);
            command.Parameters.AddWithValue("@Phone_number",  phone_txt.Text);
            connection.Open();
            command.ExecuteNonQuery();//Bağlantı açıldıktan sonra oluşturullan komutun çalışmasını sağlar.
            connection.Close();//Burda sadece ekler ama biz göremeyiz.
            BringPerson();//Bu metod yardımı ile eklenen dahiil tüm kişiler görünebilir.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void persons_dgv_CellEnter(object sender, DataGridViewCellEventArgs e)//datagridviewda üstüne tıklanan rowun elemanlarını textboxlara yerleştirmeyi sağlayacak metot.
        {//Current cell e bir datagridview ve da ya bağlı olduğunda izin verilir.
            ıd_txt.Text = persons_dgv.CurrentRow.Cells[0].Value.ToString();
            name_txt.Text = persons_dgv.CurrentRow.Cells[1].Value.ToString();
            surname_txt.Text = persons_dgv.CurrentRow.Cells[2].Value.ToString();
            phone_txt.Text = persons_dgv.CurrentRow.Cells[3].Value.ToString();
            //Bu işlemlerden sonra datagridviewda enable özellikleri kaldırılarak değişiklik yapması engellenebilir.
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string del = "DELETE FROM dbREHBER.dbo.Persons WHERE Id=@Id";
            command = new SqlCommand(del, connection);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(ıd_txt.Text)); //Bu kısım seçilen satırın tamamen silinmesini sağlar.   
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            BringPerson();

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string update = "UPDATE dbREHBER.dbo.Persons SET Name=@Name,Surname=@Surname,Phone_number=@Phone_number WHERE Id=@Id";
            command = new SqlCommand(update, connection);
            command.Parameters.AddWithValue("@Id", Convert.ToInt32(ıd_txt.Text));
            command.Parameters.AddWithValue("@Name", name_txt.Text);
            command.Parameters.AddWithValue("@Surname", surname_txt.Text);
            command.Parameters.AddWithValue("@Phone_number", phone_txt.Text);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            BringPerson();

        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            bool find_record = false;//Yazılan idye ilişkin tabloda kayıt olup olmadığını değerlendirecek olan değişkendir.
            if (find_txt.Text.Length>=1)
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM dbREHBER.dbo.Persons " + find_txt.Text;
                connection.Open();

                SqlDataReader read_record = cmd.ExecuteReader();

                while (read_record.Read())
                {
                    find_record = true;
                    ıd_txt.Text = read_record.GetValue(0).ToString();
                    name_txt.Text = read_record.GetValue(1).ToString();
                    surname_txt.Text = read_record.GetValue(2).ToString();
                    phone_txt.Text = read_record.GetValue(3).ToString();
                    break;
                }
                if (find_record == false)
                {
                    MessageBox.Show("ERROR","NO FIND RECORD",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("ENTER AGAIN","NO FIND RECORD",MessageBoxButtons.OK, MessageBoxIcon.Error);
                //BURAYA BİR METOT GELMELİ
            }
        }
    }
}
