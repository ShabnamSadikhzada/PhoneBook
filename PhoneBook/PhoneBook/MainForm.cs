using MetroFramework.Forms;

namespace PhoneBook;

public partial class MainForm : MetroForm
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Form1 form = new Form1();
        Program.MainFormInstance.Hide();
        form.ShowDialog();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {

    }

    private void btnList_Click(object sender, EventArgs e)
    {
        ListForm form = new ListForm();
        this.Hide();
        form.ShowDialog();
    }
}
