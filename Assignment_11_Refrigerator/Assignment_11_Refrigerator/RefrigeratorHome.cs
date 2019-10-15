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
        List<double> cws=new List<double>();
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
               // refrigerator.CurrentWeight();
                cws.Add(refrigerator.CurrentWeight());
                if (refrigerator.WeightTotal < cws.Sum() )
                {
                    textBoxCurrentWeight.Clear();
                    textBoxRemainingWeight.Clear();
                    MessageBox.Show("Overflow!");
                }
                else
                {
                    textBoxCurrentWeight.Text = Convert.ToString(cws.Sum());
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
