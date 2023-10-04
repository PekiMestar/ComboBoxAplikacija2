using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxIzabir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tekst;

            tekst = "Odabrali ste: ";

            textBox1.Text = tekst + comboBoxIzabir.GetItemText(comboBoxIzabir.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
