using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string username = "Username", password = "Password";
            
          
            if (ShowInputDialog(ref username, ref password) == DialogResult.OK)
            {
                MessageBox.Show("Ok");
            }
            else
                MessageBox.Show("Cancel");

        }

        private static DialogResult ShowInputDialog(ref string username, ref string password)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 90);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Name";

            System.Windows.Forms.TextBox usernameBox = new TextBox();
            usernameBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            usernameBox.Location = new System.Drawing.Point(5, 5);
            usernameBox.Text = username;
            inputBox.Controls.Add(usernameBox);

            System.Windows.Forms.TextBox passwordBox = new TextBox();
            passwordBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            passwordBox.Location = new System.Drawing.Point(5, 28);
            passwordBox.Text = password;
            inputBox.Controls.Add(passwordBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 54);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 54);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            username = usernameBox.Text;
            password = passwordBox.Text;
            if (username == "fatih" && password == "zor")
            {
                result = DialogResult.OK;
            }
            else
                result = DialogResult.Cancel;
            return result;
        }
    }
}
