using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeScreen
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void Meal_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Message goes here");
        }

        private void Snacks_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Snack Message goes here");
        }

        // Still need to create more controls (moving from one week to the next via buttons, adding a recipe, etc)
        // and including calendar functionality
    }
}
