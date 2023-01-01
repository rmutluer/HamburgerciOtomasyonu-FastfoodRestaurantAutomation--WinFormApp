using System;
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
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }
         void ChildForm(Form childform)
        {
            this.Width = childform.Width+25;
            this.Height = childform.Height+70;

            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text==childform.Text)
                {
                    durum = true;
                    //form.Dock = DockStyle.Fill;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                childform.MdiParent = this;
                //childform.Dock = DockStyle.Fill;        //start position manuel yaparsan da olur
                childform.Show();
            }

            //Ödev: Formların üstüste açılmaması ve açılan formun isminin ana formun textine  yazılması
            childform.MdiParent = this;
            childform.Show();
            
            

        }
        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new Form5());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void tsmEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());


            Menu menu1 = new Menu();
            menu1.MenuAdi = "Big King";
            menu1.Fiyati = 30M;
            
        }

        
    }
}
