using MetroFramework.Forms;
using Microsoft.Extensions.Configuration;
using PhoneBook.Data;
using PhoneBook.Models;

namespace PhoneBook
{
    public partial class EditForm : MetroForm
    {

        private int _id;
        public EditForm(int Id)
        {
            _id = Id;
            InitializeComponent();
        }

        string connection =  Program.Configuration.GetConnectionString("default");
        ApplicationDbContext context = new();
        
        private void EditForm_Load(object sender, EventArgs e)
        {
            Person person = context.People.FirstOrDefault(p => p.Id == _id);

            if(person != null)
            {
                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtPhone.Text = person.Phone;
                txtMail.Text = person.Mail;
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person person = context.People.FirstOrDefault(p => p.Id == _id);

            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.Phone = txtPhone.Text;
            person.Mail = txtMail.Text;

            context.People.Update(person);
            context.SaveChanges();
            this.Close();

        }
    }
}
