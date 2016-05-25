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
        private static string username2, password2;
        private static string username = "", password = "";
        User user1;

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            login(username, password);


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
            username2 = usernameBox.Text;
            password2 = passwordBox.Text;
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
            Exit();
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
            try
            {
                string externalIP;
                externalIP = (new System.Net.WebClient()).DownloadString("http://checkip.dyndns.org/");
                externalIP = (new System.Text.RegularExpressions.Regex(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")).Matches(externalIP)[0].ToString();
                ipm = externalIP;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                ipm = e.Message;
            }
           

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            GetExternalIP();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel3.Text = ipm;
        }

        private void login(string username, string password)
        {
            username = ""; password = "";
            DialogResult dialog_result = ShowInputDialog(ref username, ref password);
            user1 = new User(username2, password2);

            if (user1.validate_login() == true)
            {
                MessageBox.Show("Login Validated!");
            }
            else if (dialog_result == DialogResult.Cancel)
            {
                Application.Exit();
            }
            else
            {
                login(username, password);
            }
        }
    }
}
