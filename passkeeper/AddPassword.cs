using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passkeeper
{
    public partial class AddPassword : Form
    {
        ListView lv;
        //List<Data> datapwList = new List<Data>();
        public Data datapwClass;

        DesEncrytion Enc = new DesEncrytion();
        string EncPassword;

        Random rnd;

        public AddPassword(ListView lvpasswords, string pw)
        {
            InitializeComponent();
            lv = lvpasswords;
            this.EncPassword = pw;
        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            clearFields();
            Close();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TbDomain.Text) &&
                !string.IsNullOrWhiteSpace(TbUsername.Text) &&
                !string.IsNullOrWhiteSpace(TbPassword.Text))
            {
                string domain = TbDomain.Text;
                string username = TbUsername.Text;
                string password = TbPassword.Text;

                string EncryptedPW = Enc.EncryptString(password, EncPassword);
                Console.WriteLine(Enc.EncryptString(password, EncPassword));

                ListViewItem items = new ListViewItem(domain);
                items.SubItems.Add(username);
                items.SubItems.Add(password);

                lv.Items.Add(items);

                datapwClass = new Data();
                datapwClass.domain = domain;
                datapwClass.username = username;
                datapwClass.password = EncryptedPW;


                clearFields();
                Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }

        }

        private void clearFields()
        {
            TbDomain.Text = null;
            TbUsername.Text = null;
            TbPassword.Text = null;

            TbDomain.Focus();
        }

        private void BtnGeneratePassword_Click(object sender, EventArgs e)
        {
            rnd = new Random();

            string password = CreatePassword(rnd.Next(7, 20));
            TbPassword.Text = password;

            Clipboard.SetText(password);

        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            StringBuilder res = new StringBuilder();
            rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void LblShowPassword_Click(object sender, EventArgs e)
        {
            if (CbShowPassword.Checked)
            {
                TbPassword.isPassword = false;
                CbShowPassword.Checked = false;
            }
            else
            {
                TbPassword.isPassword = true;
                CbShowPassword.Checked = true;

            }
        }

        private void CbShowPassword_OnChange(object sender, EventArgs e)
        {
            if (CbShowPassword.Checked)
                TbPassword.isPassword = true;
            else
                TbPassword.isPassword = false;
        }


    }
}
