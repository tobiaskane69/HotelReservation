using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button_viewcustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostumerInfo costumerInfo = new CostumerInfo();
            costumerInfo.ShowDialog();
        }

        private void button_viewroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewRooms viewRooms = new ViewRooms();
            viewRooms.ShowDialog();
        }
    }
}
