using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_Sharp
{
    public partial class MainForm : Form
    {
        private static string ipm = "fatih";
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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

            toolStripStatusLabel1.Text = "Login";
            toolStripStatusLabel2.Text = "UserType";
            backgroundWorker1.RunWorkerAsync();


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

        private void NewSurvey()
        {
            NewSurvey_Form ns = new NewSurvey_Form();
            ns.Show();
        }

        private void MySurveys()
        {

        }

        private void Exit()
        {
            Application.Exit();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ipm);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void mySurveysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySurveys();
        }

        private void newSurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSurvey();
        }

        private void new_surveyButton_Click(object sender, EventArgs e)
        {
            NewSurvey();
        }

        private void surveysButton_Click(object sender, EventArgs e)
        {
            MySurveys();
        }


        public static void GetExternalIP()
        {
            string externalIP;
            externalIP = (new System.Net.WebClient()).DownloadString("http://checkip.dyndns.org/");
            externalIP = (new System.Text.RegularExpressions.Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(externalIP)[0].ToString();
           ipm = externalIP;
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           GetExternalIP();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel3.Text = ipm;
        }
    }
}
