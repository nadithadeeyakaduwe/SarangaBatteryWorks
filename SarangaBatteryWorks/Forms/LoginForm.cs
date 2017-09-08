//using SarangaBatteryWorks.dbConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SarangaBatteryWorks
{
    

    public partial class LoginForm : Form
    {
        private dbcon db = new dbcon();

        String un, pw;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = txtbx_username.Text.ToString();
            String password = txtbx_password.Text.ToString();

            

            if (username == "")
            {
                MessageBox.Show("Require Username Feild!!!");
            }
            else if (password == "")
            {
                MessageBox.Show("Require Password Feild!!");
            }
            else
            {
                String query = "select UserName,Password,Type from Login where UserName ='" + username + "'";
                
                DataTable userInfo = db.queryEx(query);

                foreach (DataRow dr in userInfo.Rows)
                {
                    un = dr["UserName"].ToString();
                    pw = dr["Password"].ToString();
                }

                

                Console.WriteLine("db un: "+un +", pw:" +pw);
                Console.WriteLine("txtbx un: " + un + ", pw:" + pw);


               

                if (String.IsNullOrEmpty(un))
                {
                    MessageBox.Show("This UserName is not registred!!!");
                }
                else if (username.Equals(un) && password.Equals(pw))
                {
                    MessageBox.Show("Successfully Loged In!!!");
                    
                }
                else
                {
                    MessageBox.Show("Password Incorrect!!!");
                }
            }
        }
    }
}
