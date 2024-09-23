using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPlane_Click(object sender, EventArgs e)
        {
            Plane plane = new Plane(); fPlane ft = new fPlane(plane);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbPlaneInfo.Text +=
                    string.Format("Назва: {0}, \nКраїна {1}, \nВиробник: {2}, \nКількість місць: {3}, \nМаксимальна швидкість(м/с): " + "{4}, \nчас польоту(с):" +
                    " {5}, \n{6}, \nДьюті-фрі {7}, \nПройдена дистанція(м): {8}",
                    plane.Name, plane.Country, plane.Producer, plane.Seats, plane.Max_speed, plane.Time, plane.Toilet ? "Туалет є" : "Туалету немає",
                    plane.Duty_free ? "є" : "немає", plane.GetDistance());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку ? ", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
