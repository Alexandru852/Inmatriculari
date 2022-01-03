using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Inmatriculari
{
    public partial class Verificare : Form
    {
        StocareNumere st = new StocareNumere();
        AdaugaAsigurare ad  = new AdaugaAsigurare();
         int nr=0;
        public Verificare()
        {
            InitializeComponent();
            st.Stocare();
            TxtNumar.CharacterCasing = CharacterCasing.Upper;
        }
        public bool ValidareNumarDe7(string nr)
        {
            return nr.Length == 7 && char.IsNumber(nr[2]) && char.IsNumber(nr[3]);
        }
        public bool ValidareNumarDe6(string nr)
        {
            return nr.Length == 6 && char.IsNumber(nr[1]) && char.IsNumber(nr[2]);
        }

        public int PrimesteDurata()
        {
           
            if (ad.RadioBtn12Luni.Checked)
                nr=12;
            else if(ad.RadioBtn6Luni.Checked)
                nr=6;
            return nr;
        }
        public string PrimesteData()
        {
            return ad.TxtAsigurare.Text;
        }
        public NumarInmatriculare PrimesteNumarSiData()
        {
            if(ad.RadioBtn12Luni.Checked)
                return new NumarInmatriculare(TxtNumar.Text,ad.TxtAsigurare.Text,12);
            else
                return new NumarInmatriculare(TxtNumar.Text, ad.TxtAsigurare.Text, 6);

        }
        private void BTNVerificare_Click(object sender, EventArgs e)
        {
          
            byte k = 0;
            int poz = 0;
        
            if (string.IsNullOrEmpty(TxtNumar.Text))
                MessageBox.Show("Nu ati introdus nimic in caseta!! ");
            else if(!ValidareNumarDe7(TxtNumar.Text) && !ValidareNumarDe6(TxtNumar.Text))
            {
                MessageBox.Show("Numarul de inmatriculare introdus ori nu contine cele 2 cifre specifice , ori nu respecta lungimea de 7 sau 6 caractere!!!");
            }
            else if (!st.Valideaza(TxtNumar.Text))
            {
                MessageBox.Show("Numarul: " + TxtNumar.Text + " nu exista !! ");
            }
            else
            {
                for (int i = 0; i < st.contor; i++)
                {
                    if ( st.numere[i].VerificaValabilitate() && st.numere[i].ValidareNumar(TxtNumar.Text))
                    {
                        k = 1;
                        poz = i;
                        break;
                    }
                    if (!st.numere[i].VerificaValabilitate() && st.numere[i].ValidareNumar(TxtNumar.Text))
                    {
                        k = 2;
                        poz = i;
                        break;
                    }
                    if(!st.numere[i].VerificaValabilitate() && !st.numere[i].ValidareNumar(TxtNumar.Text))
                    {
                        k=3;
                    }

                }
                if (k == 1)
                {

                    if (MessageBox.Show(st.numere[poz].toString() + "\nDoriti sa aflati mai multe ?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        MessageBox.Show("Emisa " + st.numere[poz].Valabilitate+". Exipira la data de: "+((Convert.ToDateTime(st.numere[poz].Valabilitate)).AddMonths((int)st.numere[poz].Perioada).ToString("MM.dd.yyyy")));
                    }

                }
                else if (k == 2)
                {
                    if(MessageBox.Show(st.numere[poz].toString()+".Doriti sa o inscrieti ?","Confirmare",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        this.Hide();
                        ad.ShowDialog();
                        if (!string.IsNullOrEmpty(ad.TxtAsigurare.Text) && ad.RadioBtn12Luni.Checked || !string.IsNullOrEmpty(ad.TxtAsigurare.Text) && ad.RadioBtn6Luni.Checked)

                        {
                            st.numere[poz].Valabilitate = PrimesteData();
                            st.numere[poz].Perioada = PrimesteDurata();
                            TxtNumar.Text = string.Empty;
                            this.Show();
                            MessageBox.Show("Asigurare creeata!");
                       }
                        else
                       {
                           this.Refresh();
                           this.Show();
                       }
                    }
                }
                else if(k==3)
                {
                    if(MessageBox.Show("Numar inexistent!Doriti sa il adaugati in baza de date ? Automat trebuie sa va faceti si asigurare","Confirmare",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                       
                       this.Hide();
                        ad.ShowDialog();
                       if(!string.IsNullOrEmpty(ad.TxtAsigurare.Text) && ad.RadioBtn12Luni.Checked || !string.IsNullOrEmpty(ad.TxtAsigurare.Text) && ad.RadioBtn6Luni.Checked)
                        {
                            st.AdaugaNumar(PrimesteNumarSiData());
                            TxtNumar.Text = string.Empty;
                            this.Refresh();
                            this.Show();
                            MessageBox.Show("Numar adaugat! ");
                       }
                       else
                       {
                           this.Refresh();
                           this.Show();
                       }
                        
                        
                    }
                }
            }
            }
        }
    }

