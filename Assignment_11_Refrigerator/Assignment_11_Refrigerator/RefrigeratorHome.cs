using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_11_Refrigerator;
using Exception = System.Exception;

namespace Assignment_10_Vehicle
{
    public partial class RefrigeratorHome : Form
    {
        public RefrigeratorHome()
        {
            InitializeComponent();
        }
        Refrigerator refrigerator=new Refrigerator();
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                refrigerator.WeightTotal = Convert.ToDouble(textBoxMaximumWeight.Text);
                textBoxMaximumWeight.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                refrigerator.Item = Convert.ToInt32(textBoxNoOfItems.Text);
                refrigerator.WeightUnit = Convert.ToDouble(textBoxWeightPerUnit.Text);
                textBoxNoOfItems.Clear();
                textBoxWeightPerUnit.Clear();
                if (refrigerator.WeightTotal < refrigerator.CurrentWeight())
                {
                    textBoxCurrentWeight.Clear();
                    textBoxRemainingWeight.Clear();
                    MessageBox.Show("Overflow!");
                }
                else
                {
                    textBoxCurrentWeight.Text = Convert.ToString(refrigerator.CurrentWeight());
                    textBoxRemainingWeight.Text = Convert.ToString(refrigerator.RemainingWeight());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
