using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupportApp
{
    public partial class ParamsForm : Form
    {
        public ParamsForm()
        {
            InitializeComponent();
            string commandToDB = DBHelper.CallLocalDataBase("SELECT Url FROM Options", true);
            url.Text = commandToDB.Replace(" ","");
            commandToDB = DBHelper.CallLocalDataBase("SELECT Port FROM Options", true);
            port.Text = commandToDB.Replace(" ", "");
            commandToDB = DBHelper.CallLocalDataBase("SELECT Login FROM Options", true);
            login.Text = commandToDB.Replace(" ", "");
            commandToDB = DBHelper.CallLocalDataBase("SELECT Password FROM Options", true);
            password.Text = commandToDB.Replace(" ", "");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // save params here
            string new_url =  url.Text;
            string new_port = port.Text;
            string new_login = login.Text;
            string new_pass = password.Text;
            string command = DBHelper.CallLocalDataBase("UPDATE Options SET Url='" +new_url+"', Port='"+new_port+"', Login='"+new_login+"', Password='"+new_pass+"' WHERE Id=1", false);
            MessageBox.Show(command);
            // close form
            this.Close();
        }

        private void ParamsForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
