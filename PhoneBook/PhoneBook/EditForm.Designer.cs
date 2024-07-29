namespace PhoneBook
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbSavePerson = new GroupBox();
            btnSave = new Button();
            txtMail = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            grbSavePerson.SuspendLayout();
            SuspendLayout();
            // 
            // grbSavePerson
            // 
            grbSavePerson.Controls.Add(btnSave);
            grbSavePerson.Controls.Add(txtMail);
            grbSavePerson.Controls.Add(label4);
            grbSavePerson.Controls.Add(txtPhone);
            grbSavePerson.Controls.Add(label3);
            grbSavePerson.Controls.Add(txtLastName);
            grbSavePerson.Controls.Add(label2);
            grbSavePerson.Controls.Add(txtFirstName);
            grbSavePerson.Controls.Add(label1);
            grbSavePerson.Font = new Font("Segoe UI", 15F);
            grbSavePerson.Location = new Point(23, 24);
            grbSavePerson.Name = "grbSavePerson";
            grbSavePerson.Size = new Size(345, 309);
            grbSavePerson.TabIndex = 1;
            grbSavePerson.TabStop = false;
            grbSavePerson.Text = "Kişi düzenle";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Blue;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(127, 217);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(158, 50);
            btnSave.TabIndex = 5;
            btnSave.Text = "Düzenle";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Segoe UI", 12F);
            txtMail.Location = new Point(111, 163);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(203, 29);
            txtMail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(14, 169);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 0;
            label4.Text = "Mail";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(111, 123);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(203, 29);
            txtPhone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(14, 129);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(111, 83);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(203, 29);
            txtLastName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(14, 89);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 0;
            label2.Text = "Soyadı";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(111, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(203, 29);
            txtFirstName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(14, 49);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 356);
            Controls.Add(grbSavePerson);
            Name = "EditForm";
            Resizable = false;
            Text = "EditForm";
            Load += EditForm_Load;
            grbSavePerson.ResumeLayout(false);
            grbSavePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSavePerson;
        private Button btnSave;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
    }
}