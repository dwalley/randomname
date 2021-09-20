using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RandomStudent2
{
    public partial class RSG : Form
    {
        public RSG()
        {
            InitializeComponent();
        }

        private void btn_getNext_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            int ms = dt.Millisecond;
            int num_available = lst_available.Items.Count;
            if (num_available <= 0)
            {
                return;
            }
            float fms = Convert.ToSingle(ms);
            float fna = Convert.ToSingle(num_available);
            int random_index = (int) (fms / 1000.0 * fna);
            lst_random.Items.Add(lst_available.Items[random_index]);
            lst_available.Items.Remove(lst_available.Items[random_index]);
            if (lst_available.Items.Count <= 0)
            {
                btn_getNext.Text = "That\'s all";
            }
        }
    }
}
