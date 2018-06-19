using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RdlcReportHeaderExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var list = Enumerable.Range(1, 1000).Select(x => new Product()
            {
                Id = x,
                Name = $"Product {x}",
                Price = x * 100
            });
            this.ProductBindingSource.DataSource = list;
            this.reportViewer1.RefreshReport();
        }
    }
}