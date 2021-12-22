using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankzaken
{
    class BankRekening
    {
        private int rekeningnummer;
        private string naam;
        private int saldo; 
        private static int volgendeVrijeRekeningnummer = 2001;

        public int Rekeningnummer
        {
            get { return rekeningnummer; }
        }

        public string Naam
        {
            get { return naam; }
        }

        public int Saldo
        {
            get { return saldo; }
        }

        public BankRekening(string naam)
        {
            this.naam = naam;
            saldo = 0;
            rekeningnummer = volgendeVrijeRekeningnummer;
            ++volgendeVrijeRekeningnummer;
        }


        public BankRekening(string naam, int saldo)
        {
            this.naam = naam;
            this.saldo = saldo;
            rekeningnummer = volgendeVrijeRekeningnummer;
            ++volgendeVrijeRekeningnummer;
        }


        public void NeemOp(int bedrag)
        {
            if (bedrag >= 0 && (saldo - bedrag) >= 0)
            {
                 saldo -= bedrag;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Je mag niet meer uitnemen dan er inzit");
            }

        }

        public void Stort(int bedrag)
        {
            if (bedrag >= 0)
            {
                saldo += bedrag;
            }

        }

        public void MaakOver(BankRekening andereRekening, int bedrag)
        {
            if(bedrag >= 0 && (saldo - bedrag) >= 0)
            {
                saldo = saldo -= bedrag;
                andereRekening.saldo += bedrag;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Je mag niet meer uitnemen dan er inzit");
            }
        }

    }
}
