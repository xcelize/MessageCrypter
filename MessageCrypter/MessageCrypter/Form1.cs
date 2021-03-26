using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageCrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Crypte_Click(object sender, EventArgs e)
        {
            if (tbx_MessageACrypter.Text.Length != 0 && tbx_Cle.Text.Length != 0)
            {
                Cryptage c = new Cryptage();
                tbx_MessageDecrypte.Text = c.Crypter(tbx_MessageACrypter.Text, tbx_Cle.Text);
            }
        }

        private void btn_Decrypte_Click(object sender, EventArgs e)
        {
            if (tbx_Cle.Text.Length != 0 && tbx_MessageDecrypte.Text.Length != 0)
            {
                Cryptage c = new Cryptage();
                tbx_MessageACrypter.Text = c.Decrypter(tbx_MessageDecrypte.Text, tbx_Cle.Text);
            }
        }
    }
}
