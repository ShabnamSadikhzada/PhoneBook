using MetroFramework.Forms;
using Microsoft.Extensions.Configuration;
using PhoneBook.Data;
using PhoneBook.Models;

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
                else if (item is NumericUpDown nmr)
                {
                    nmr.Value = nmr.Minimum;
                }
                else if (item is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }
            }
        }
        
        string connection = Program.Configuration.GetConnectionString("default");
        ApplicationDbContext context = new ApplicationDbContext();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person person = new()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                Mail = txtMail.Text
            };

            context.People.Add(person);
            context.SaveChanges();
            MessageBox.Show(
                  text: "Kayıt Eklendi",
                  caption: "Kayıt Eklleme Bildirimi",
                  buttons: MessageBoxButtons.OK,
                  icon: MessageBoxIcon.Asterisk
            );
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           Program.MainFormInstance.Show();
        } 
    }
}
