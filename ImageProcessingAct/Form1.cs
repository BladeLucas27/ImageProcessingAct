using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingAct
{
    public partial class Form1 : Form
    {
        private Part1 part1Control;
        private Part2 part2Control;
        public Form1()
        {
            InitializeComponent();

            part1Control = new Part1();
            part2Control = new Part2();

            // Show Part1 by default
            ShowPage(part1Control);

            // Wire up menu events
            menuItemPart1.Click += (s, e) => ShowPage(part1Control);
            menuItemPart2.Click += (s, e) => ShowPage(part2Control);
        }

        private void ShowPage(UserControl page)
        {
            panelMain.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
