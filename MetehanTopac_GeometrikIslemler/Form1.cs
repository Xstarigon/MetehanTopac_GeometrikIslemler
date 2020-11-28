using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetehanTopac_GeometrikIslemler.Classes;

namespace MetehanTopac_GeometrikIslemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Daire _daire = new Daire();
        Dikdortgen _dikdortgen = new Dikdortgen();
        Kare _kare = new Kare();
        DikUcgen _dikUcgen = new DikUcgen();
        EskenarUcgen _eskenarUcgen = new EskenarUcgen();
        private void button1_Click(object sender, EventArgs e)
        {
            _daire.Radius = Convert.ToDouble(numericUpDown1.Value);
            label2.Text = "Çevre: " + Math.Round(_daire.CevreHesapla(),2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _daire.Radius = Convert.ToDouble(numericUpDown1.Value);
            label2.Text = "Alan: " + Math.Round(_daire.AlanHesapla(), 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _kare.UzunKenar = Convert.ToDouble(numericUpDown2.Value);
            label3.Text = "Çevre: " + Math.Round(_kare.CevreHesapla(), 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _kare.UzunKenar = Convert.ToDouble(numericUpDown2.Value);
            label3.Text = "Alan: " + Math.Round(_kare.AlanHesapla(), 2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _dikdortgen.UzunKenar = Convert.ToDouble(numericUpDown3.Value);
            _dikdortgen.KisaKenar = Convert.ToDouble(numericUpDown4.Value);
            label5.Text = "Çevre: " + Math.Round(_dikdortgen.CevreHesapla(), 2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _dikdortgen.UzunKenar = Convert.ToDouble(numericUpDown3.Value);
            _dikdortgen.KisaKenar = Convert.ToDouble(numericUpDown4.Value);
            label5.Text = "Alan: " + Math.Round(_dikdortgen.AlanHesapla(), 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _dikUcgen.TabanKenar = Convert.ToDouble(numericUpDown6.Value);
            _dikUcgen.Yukseklik = Convert.ToDouble(numericUpDown5.Value);
            label9.Text = "Çevre: " + Math.Round(_dikUcgen.CevreHesapla(), 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _dikUcgen.TabanKenar = Convert.ToDouble(numericUpDown6.Value);
            _dikUcgen.Yukseklik = Convert.ToDouble(numericUpDown5.Value);
            label9.Text = "Alan: " + Math.Round(_dikUcgen.AlanHesapla(), 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label5.Text = "";
            label9.Text = "";
            label12.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _eskenarUcgen.TabanKenar = Convert.ToDouble(numericUpDown8.Value);
            label12.Text = "Çevre: " + Math.Round(_eskenarUcgen.CevreHesapla(), 2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _eskenarUcgen.TabanKenar = Convert.ToDouble(numericUpDown8.Value);
            label12.Text = "Alan: " + Math.Round(_eskenarUcgen.AlanHesapla(), 2);
        }
    }
}
