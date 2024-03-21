using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> kelimeler = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            kelimeler.Add("Cat", "Kedi");
            kelimeler.Add("Dog", "Köpek");
        }

        private void cevrilen_TextChanged(object sender, EventArgs e)
        {
            cevrilmis.Clear();
            foreach (var kelime in kelimeler)
            {
                if (cevrilen.Text == kelime.Key)
                {
                    cevrilmis.Text = kelime.Value;
                    break;
                }
                else
                {
                    cevrilmis.Text = "Kelime Bulunamadı";
                }
            }
        }
    }
}
