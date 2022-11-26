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
    public partial class MyMdiForm : System.Windows.Forms.Form
    {
        public MyMdiForm()
        {
            InitializeComponent();
        }

        void ChildForm(Form childform)
        {
            this.Width = childform.Width + 27;
            this.Height = childform.Height + 70;

            bool durum = false;
            foreach (Form form in this.MdiChildren)  // Şunu sadece if kullanarak DENE !!
            {
                if (form.Text == childform.Text)
                {
                    durum = true;
                    //form.Dock = DockStyle.Fill;  // Formun sayfada dengeli açılması için
                    // PROPERTİLERDEN BÜTÜN FORMLARI START POSİTİON KISMINI MANUAL ALIYORUZ !!!
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
                //childform.Dock = DockStyle.Fill;
                childform.Show();
            }
            
            childform.MdiParent = this;
            childform.Show();
            
        }

        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void tsmEkstraMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }
    }
}
