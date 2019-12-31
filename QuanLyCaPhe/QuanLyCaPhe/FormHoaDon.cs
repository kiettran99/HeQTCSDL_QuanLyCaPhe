using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCaPhe.BSLayer;

namespace QuanLyCaPhe
{
    public partial class FormHoaDon : Form
    {
        ThongKeHoaDon tkHoaDon = new ThongKeHoaDon();
        public FormHoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            dgvHoaDon.DataSource = tkHoaDon.LayThongKeHoaDon().Tables[0];
        }

        private void txtngay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
