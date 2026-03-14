using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_103022400015
{
    public partial class Form1 : Form
    {
        double hasil = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelSatuanAwal_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNilaiAwal_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSatuanAkhir_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSatuanAkhir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelNilaiAkhir_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNilaiAkhir_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (comboBoxSatuanAwal.Text == "" || comboBoxSatuanAkhir.Text == "")
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            double nilaiAwal;
            if (!double.TryParse(textBoxNilaiAwal.Text, out nilaiAwal))
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            string satuanAwal = comboBoxSatuanAwal.Text;
            string satuanAkhir = comboBoxSatuanAkhir.Text;
            double hasil = 0;

            if (satuanAwal == "Celcius" && satuanAkhir == "Celcius")
                hasil = nilaiAwal;
            else if (satuanAwal == "Celcius" && satuanAkhir == "Fahrenheit")
                hasil = (nilaiAwal * 9 / 5) + 32;
            else if (satuanAwal == "Celcius" && satuanAkhir == "Kelvin")
                hasil = nilaiAwal + 273.15;
            else if (satuanAwal == "Celcius" && satuanAkhir == "Reamur")
                hasil = nilaiAwal * 4 / 5;
            else if (satuanAwal == "Fahrenheit" && satuanAkhir == "Celcius")
                hasil = (nilaiAwal - 32) * 5 / 9;
            else if (satuanAwal == "Fahrenheit" && satuanAkhir == "Fahrenheit")
                hasil = nilaiAwal;
            else if (satuanAwal == "Fahrenheit" && satuanAkhir == "Kelvin")
                hasil = (nilaiAwal - 32) * 5 / 9 + 273.15;
            else if (satuanAwal == "Fahrenheit" && satuanAkhir == "Reamur")
                hasil = (nilaiAwal - 32) * 4 / 9;
            else if (satuanAwal == "Kelvin" && satuanAkhir == "Celcius")
                hasil = nilaiAwal - 273.15;
            else if (satuanAwal == "Kelvin" && satuanAkhir == "Fahrenheit")
                hasil = (nilaiAwal - 273.15) * 9 / 5 + 32;
            else if (satuanAwal == "Kelvin" && satuanAkhir == "Kelvin")
                hasil = nilaiAwal;
            else if (satuanAwal == "Kelvin" && satuanAkhir == "Reamur")
                hasil = (nilaiAwal - 273.15) * 4 / 5;
            else if (satuanAwal == "Reamur" && satuanAkhir == "Celcius")
                hasil = nilaiAwal * 5 / 4;
            else if (satuanAwal == "Reamur" && satuanAkhir == "Fahrenheit")
                hasil = (nilaiAwal * 9 / 4) + 32;
            else if (satuanAwal == "Reamur" && satuanAkhir == "Kelvin")
                hasil = (nilaiAwal * 5 / 4) + 273.15;
            else if (satuanAwal == "Reamur" && satuanAkhir == "Reamur")
                hasil = nilaiAwal;
            textBoxNilaiAkhir.Text = hasil.ToString();
        }
    }
}
