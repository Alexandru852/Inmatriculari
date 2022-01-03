using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmatriculari
{
    public partial class AdaugaAsigurare : Form
    {
        public AdaugaAsigurare()
        {
            InitializeComponent();
        }
        public void BtnSalveaza_Click(object sender, EventArgs e)
        {
            bool valid = true;
           if(string.IsNullOrEmpty(this.TxtAsigurare.Text))
            {
                MessageBox.Show("Nu ati introuds nimic in caseta!! ");
                return;
            }
           if(!RadioBtn12Luni.Checked && !RadioBtn6Luni.Checked)
            {
                MessageBox.Show("Nu ati bifat pentru ce durata doriti asigurarea! ");
                return;
            }
            for (int i = 0; i<TxtAsigurare.Text.Length;i++)
            {
                if(!char.IsNumber(TxtAsigurare.Text[i]) && TxtAsigurare.Text[i]!='.')
                {
                    MessageBox.Show("Nu ai introdus corect data! Urmareste sa fie simbolul '.' intre luna,zi si an");
                    valid = false;
                    break;
                   
                }
                
            }
            if (valid)
            {
              
                if (!string.Equals(TxtAsigurare.Text, Convert.ToDateTime(TxtAsigurare.Text).ToString("MM.dd.yyyy")))
                {
                    MessageBox.Show("Data incorecta!!");
                }
                else if(Convert.ToDateTime(TxtAsigurare.Text) < DateTime.Now)
                {
                    MessageBox.Show("Data incorecta!!");
                }
                else
                this.Hide();
            }
        }
        
    }
}
