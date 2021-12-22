using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankzaken
{
    public partial class BankrekeningForm : Form

    {
        private BankRekening bankrekeningLinks;
        private BankRekening bankrekeningRechts;
        
        public BankrekeningForm()
        {
            InitializeComponent();
            bankrekeningLinks = new BankRekening("Duck, Dagobert");
            bankrekeningRechts = new BankRekening("Gans, Gijs", 100);
            lbSaldoLeft.Text = Convert.ToString(bankrekeningLinks.Saldo.ToString("C"));
            lbSaldoRight.Text = Convert.ToString(bankrekeningRechts.Saldo.ToString("C"));
        }

        private void BankrekeningForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("a");
        } 

        private void btStortenLinks_Click(object sender, EventArgs e)
        {
            if(lbSaldoLeft.Text != null)
            {
                bankrekeningLinks.Stort(Convert.ToInt32(tbSaldoGegeve.Text));
                lbSaldoLeft.Text = Convert.ToString(bankrekeningLinks.Saldo.ToString("C"));
            }
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btOpnemenLeft_Click(object sender, EventArgs e)
        {
            if(lbSaldoLeft.Text != null)
            {
                bankrekeningLinks.NeemOp(Convert.ToInt32(tbSaldoGegeve.Text));
                lbSaldoLeft.Text = Convert.ToString(bankrekeningLinks.Saldo.ToString("C"));
            }


        }

        private void btStortenRight_Click(object sender, EventArgs e)
        {
            if (lbSaldoRight.Text != null)
            {
                bankrekeningRechts.Stort(Convert.ToInt32(tbSaldoGegeve.Text));
                lbSaldoRight.Text = Convert.ToString(bankrekeningRechts.Saldo.ToString("C"));
            }
        }

        private void btOpnemenRight_Click(object sender, EventArgs e)
        {
            if (lbSaldoRight.Text != null)
            {
                bankrekeningRechts.NeemOp(Convert.ToInt32(tbSaldoGegeve.Text));
                lbSaldoRight.Text = Convert.ToString(bankrekeningRechts.Saldo.ToString("C"));
            }

        }

        private void btRightToLeft_Click(object sender, EventArgs e)
        {
            bankrekeningRechts.MaakOver(bankrekeningLinks, Convert.ToInt32(tbSaldoGegeve.Text));
            lbSaldoLeft.Text = Convert.ToString(bankrekeningLinks.Saldo.ToString("C"));
            lbSaldoRight.Text = Convert.ToString(bankrekeningRechts.Saldo.ToString("C"));
        }

        private void btLeftToRight_Click(object sender, EventArgs e)
        {
            bankrekeningLinks.MaakOver(bankrekeningRechts, Convert.ToInt32(tbSaldoGegeve.Text));
            lbSaldoLeft.Text = Convert.ToString(bankrekeningLinks.Saldo.ToString("C"));
            lbSaldoRight.Text = Convert.ToString(bankrekeningRechts.Saldo.ToString("C"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaldoLinksTest.Text = Convert.ToString(bankrekeningLinks.Saldo.ToString("C"));
            SaldoRechtsTest.Text = Convert.ToString(bankrekeningRechts.Saldo.ToString("C"));
            RekeningNmrLinks.Text = Convert.ToString(bankrekeningLinks.Rekeningnummer);
            RekeningNmrRechts.Text = Convert.ToString(bankrekeningRechts.Rekeningnummer);
            
        }
    }
}
