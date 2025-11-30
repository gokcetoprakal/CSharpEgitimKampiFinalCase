using FinancialCrmFinalCase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinancialCrmFinalCase
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserID.Text);
            var updatedValue = db.Users.Find(id);
            string name = txtUserName.Text;
            string surname = txtUserSurname.Text;
            string mail = txtUserMail.Text;
            string password = txtUserPassword.Text;

            

            updatedValue.UserName = name;
            updatedValue.UserSurname = surname;
            if (txtUserMail.Text.EndsWith("@crm.com"))
            {
                updatedValue.Mail = mail;
            }
            else
            {
                MessageBox.Show("Kural: Mailler '@crm.com' ile oluşturulmalıdır. Başka mailler ile giriş yapılamaz.");
            }
            if(txtUserPassword.Text.Length >= 4)
            {
            updatedValue.Password = password;
            }
            else
            {
                MessageBox.Show("Kural: Şifre en az 4 karakterli olmalıdır.");

            }

            db.SaveChanges();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
        FrmCategories frm = new FrmCategories();
        frm.Show();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            FrmTransactions frm = new FrmTransactions();
            frm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
