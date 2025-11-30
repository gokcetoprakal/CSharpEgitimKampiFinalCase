using FinancialCrmFinalCase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrmFinalCase
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        //giriş yapma
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mail = txtLoginMail.Text;
            string password = txtLoginPassword.Text;
              var user = db.Users
                             .FirstOrDefault(x => x.Mail == mail && x.Password == password);

                if (user != null)
                {
                    FrmDashboard frmdb = new FrmDashboard();
                frmdb.Show();
                this.Hide();
                }
                else
                {
                    MessageBox.Show("Mail veya şifre hatalı! Lütfen tekrar deneyiniz.");
                }
        }
        //kayıt olma

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtRegisterName.Text;
            string surname = txtRegisterSurname.Text;
            string mail = txtRegisterMail.Text;
            string password = txtRegisterPassword.Text;
            Users users = new Users();
            users.UserName = name;
            users.UserSurname = surname;
            if (txtRegisterMail.Text.EndsWith("@crm.com"))
            {
                users.Mail = mail;
            }
            else
            {
                MessageBox.Show("Kural: Mailler '@crm.com' ile oluşturulmalıdır. Başka mailler ile giriş yapılamaz.");
                return;
            }
            if (txtRegisterPassword.Text.Length >= 4) { 
            users.Password = password;
            }
            else
            {
                MessageBox.Show("Kural: Şifre en az 4 karakterli olmalıdır.");
                return;
            }
            
        }
        

    }
}
