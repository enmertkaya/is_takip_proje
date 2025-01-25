using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using is_takip_proje.Entity;

namespace is_takip_proje.Formlar
{
    public partial class Departmanlar : Form
    {
        public Departmanlar()
        {
            InitializeComponent();
        }
        void Listele ()
        {
            DbisTakipEntities db = new DbisTakipEntities();
            var degerler = (from x in db.TblDepartmanlar
                            select new
                            {
                                x.ID,
                                x.Ad
                            }).ToList();
            gridControl1.DataSource = degerler;
        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
