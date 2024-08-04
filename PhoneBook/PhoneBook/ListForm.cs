using MetroFramework.Forms;
using PhoneBook.Data;
using PhoneBook.Models;

namespace PhoneBook
{
    public partial class ListForm : MetroForm
    {
        public ListForm()
        {
            InitializeComponent();
        }

        string connection = Properties.PhoneBook.Default.Connection;
        ApplicationDbContext context = new();

        #region Load Function
        void Refresh()
        {
            lstPeople.Items.Clear();

            context = new(); // bunu yazmayınca düzenlemeden sonrakı değişiklikler görünmüyor
            var people = context.People.ToList(); 

            foreach (var person in people)
            {
                ListViewItem item = new(person.Id.ToString());
                item.SubItems.Add(person.FirstName);
                item.SubItems.Add(person.LastName);
                item.SubItems.Add(person.Phone);
                item.SubItems.Add(person.Mail);

                lstPeople.Items.Add(item);
            }
        }
        #endregion

        private void ListForm_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void cmsRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }


        private void cmsSil_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to delete.",
                    "Delete Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to delete the selected record?",
                "Delete Item",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);


            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int selectedId = Convert.ToInt32(lstPeople.SelectedItems[0].Text);
            Person person = context.People.FirstOrDefault(p => p.Id == selectedId);
            context.People.Remove(person);
            context.SaveChanges();

            MessageBox.Show(
                text: "Kayıt Silindi",
                caption: "Kayıt Silme Bildirimi",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Asterisk
            );
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainFormInstance.Show();
        }

        private void cmsEdit_Click(object sender, EventArgs e)
        {
            if (lstPeople.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a record to update.",
                    "Update Item",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
             
            int selectedId = Convert.ToInt32(lstPeople.SelectedItems[0].Text);
            EditForm frm = new(selectedId); 
            frm.ShowDialog();
        }
    }
}
