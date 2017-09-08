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
    public partial class RegisterForm : Form
    {
        private dbcon db = new dbcon();
        String un, pw, type, confirmUn, confirmType, checkUN;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void txtbx_reg_repw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_reg_repw_Leave(object sender, EventArgs e)
        {
           
        }

        private void btn_reg_register_Click(object sender, EventArgs e)
        {

            //confirm password error handling
            ErrorProvider ep = new ErrorProvider();
            if (!txtbx_reg_repw.Text.ToString().Equals(txtbx_reg_pw.Text.ToString()))
            {
                lbl_reg_notmatched.Visible = true;
            }
            else
            {
                lbl_reg_notmatched.Visible = false;



                un = txtbx_reg_un.Text.ToString();
                pw = txtbx_reg_pw.Text.ToString();
                type = cmbx_register_type.GetItemText(cmbx_register_type.SelectedItem);

                if (un == "")
                {
                    MessageBox.Show("Require Username Feild!!!");
                }
                else if (pw == "")
                {
                    MessageBox.Show("Require Password Feild!!");
                }
                else if (txtbx_reg_repw.Text.ToString() == "")
                {
                    MessageBox.Show("Require Re-Enter Password Feild!!");
                }
                else
                {

                    //check username already there or not


                    String query = "select UserName from Login where UserName ='" + un + "'";

                    DataTable ckuserInfo = db.queryEx(query);

                    foreach (DataRow dr in ckuserInfo.Rows)
                    {
                        checkUN = dr["UserName"].ToString();
                    }

                    if (!String.IsNullOrEmpty(checkUN))
                    {
                        checkUN = "";
                        MessageBox.Show("This Username is already in the System!!! Use another Username.");

                    }
                    else
                    {
                        String query1 = "INSERT INTO Login(UserName,Password,Type)VALUES('" + un + "','" + pw + "','" + type + "')";
                        int isSuccess = db.NonQueryEx(query1);

                        if (isSuccess <= 0)
                        {
                            MessageBox.Show("Not Successful!!!");
                            txtbx_reg_un.Clear();
                            txtbx_reg_pw.Clear();
                            txtbx_reg_repw.Clear();
                            cmbx_register_type.SelectedIndex = -1;
                        }
                        else
                        {
                            String query2 = "select UserName,Type from Login where UserName ='" + un + "'";

                            DataTable userInfo = db.queryEx(query2);

                            foreach (DataRow dr in userInfo.Rows)
                            {
                                confirmUn = dr["UserName"].ToString();
                                confirmType = dr["Type"].ToString();
                            }

                            DialogResult r = MessageBox.Show("Successfully Added User " + confirmUn + " as a " + confirmType);

                            if (r == DialogResult.OK)
                                this.Close();
                        }
                    }

                }

            }  
        }

       
    }
}
