using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic;
using MetroFramework.Forms;
using Microsoft.Extensions.Configuration;

namespace PhoneBook
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Clear(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox txt)
                {
                    txt.Clear();
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connection = Program.Configuration.GetConnectionString("default");
            using SqlConnection con = new SqlConnection(connection);

            using SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = $"insert into People (FirstName, LastName, Mail, Phone) VALUES(@firstName, @lastName, @mail, @phone);";
            cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("mail", txtMail.Text);
            cmd.Parameters.AddWithValue("phone", txtPhone.Text);


            cmd.CommandType = CommandType.Text;


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            bool result = cmd.ExecuteNonQuery() > 0;

            //MessageBox.Show(result ? "Kayit Eklendi" : "Islem Hatasi");
            MessageBox.Show(
                result ? "Kayit Eklendi" : "Islem Hatasi",
                "Kayit Ekleme Bildirimi",
                MessageBoxButtons.OK,
                result ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error
            );

            //txtFirstName.Text = txtLastName.Text = txtMail.Text = txtPhone.Text = string.Empty;
            Clear(grbSavePerson);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainFormInstance.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
