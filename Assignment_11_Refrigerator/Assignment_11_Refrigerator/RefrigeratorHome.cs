﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_11_Refrigerator;

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
            refrigerator.WeightTotal = Convert.ToDouble(textBoxMaximumWeight.Text);
            textBoxMaximumWeight.Clear();
        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            refrigerator.Item = Convert.ToInt32(textBoxNoOfItems.Text);
            refrigerator.WeightUnit = Convert.ToDouble(textBoxWeightPerUnit.Text);
            textBoxNoOfItems.Clear();
            textBoxWeightPerUnit.Clear();
            textBoxCurrentWeight.Text = Convert.ToString(refrigerator.CurrentWeight());
            textBoxRemainingWeight.Text = Convert.ToString(refrigerator.RemainingWeight());
        }
    }
}
