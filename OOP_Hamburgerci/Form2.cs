﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Form1.menuler.Add(new Menu { MenuAdi = txtMenuAdi.Text, Fiyati = nmrMenuFiyati.Value });

            Fonksiyon.Temizle(this.Controls);
            
            MessageBox.Show("Menü baarılı şekilde eklendi");
        }
    }
}
