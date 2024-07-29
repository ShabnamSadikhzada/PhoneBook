namespace PhoneBook
{
    partial class MainForm
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
            btnSave = new Button();
            btnList = new Button();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Teal;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(23, 72);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 318);
            btnSave.TabIndex = 0;
            btnSave.Text = "Kişi Ekle";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.FromArgb(128, 128, 255);
            btnList.Cursor = Cursors.Hand;
            btnList.Font = new Font("Segoe UI", 15F);
            btnList.ForeColor = Color.White;
            btnList.Location = new Point(216, 235);
            btnList.Name = "btnList";
            btnList.Size = new Size(287, 155);
            btnList.TabIndex = 0;
            btnList.Text = "Kişi Listesi";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(10, 128, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Segoe UI", 15F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(216, 72);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(287, 155);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Kişi Arama";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // MainForm
            // 
            AccessibleRole = AccessibleRole.Clock;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 411);
            Controls.Add(btnSearch);
            Controls.Add(btnList);
            Controls.Add(btnSave);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "MainForm";
            Resizable = false;
            Text = "Telefon Rehberi";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnList;
        private Button btnSearch;
    }
}