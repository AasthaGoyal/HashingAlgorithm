using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;


namespace HashingAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            byte[] password = ASCIIEncoding.ASCII.GetBytes(txtPassword.Text);
            HashAlgorithm hash = null;

            Random r = new Random();
            int number = r.Next();

            int algorithm = number % 4;
            switch (algorithm)
            {
                case 1: hash = MD5.Create();
                    break;
                case 2: hash = SHA1.Create();
                    break;
                case 0: hash = SHA256.Create();
                    break;
                case 3: hash = SHA256.Create();
                    break;
                default:
                    hash = SHA512.Create();

                    break;
            }

            password = hash.ComputeHash(password);
            lblMD5.Text = Convert.ToBase64String(password);

            /*
            HashAlgorithm hash = MD5.Create();
            byte[] md5Password = hash.ComputeHash(password);

            hash = SHA1.Create();
            byte[] sh1Password = hash.ComputeHash(password);

            hash = SHA256.Create();
            byte[] sh256Password = hash.ComputeHash(password);

            hash = SHA512.Create();
            byte[] sh512Password = hash.ComputeHash(password);

            lblMD5.Text = Convert.ToBase64String(md5Password);
            lblSHA1.Text = Convert.ToBase64String(sh1Password);
            lblSHA256.Text = Convert.ToBase64String(sh256Password);
            lblSHA512.Text = Convert.ToBase64String(sh512Password);

            //64 means we are using unique code 
            */
        }
    }
}
