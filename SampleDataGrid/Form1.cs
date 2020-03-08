using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleDataGrid
{
    public partial class Form1 : Form
    {
        StratData stratData = null;
        public Form1()
        {
            InitializeComponent();

            stratData = new StratData();

            typeof(DataGridView).InvokeMember(
            "DoubleBuffered",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
            null,
            dataGridView1,
            new object[] { true });
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = stratData.GetStrategyData();
        }
    }
}
