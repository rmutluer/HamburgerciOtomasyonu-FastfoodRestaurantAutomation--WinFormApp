using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public static class Fonksiyon
    {

        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                }
                if (item is RadioButton)
                {
                    RadioButton rdo = new RadioButton();
                    if (rdo.Name=="rdKucuk")
                    {
                        rdo.Checked = true;
                    }
                    else
                    {
                        rdo.Checked = false;
                    }
                }
                if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                if (item is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)item).Controls);
                }
                if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls);
                }

            }
        }

    }
}
