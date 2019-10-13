using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11_Refrigerator
{
    class Refrigerator
    {
        private double weightTotal;
        private int item;
        private double weightUnit;
        private double currentWeight;
        private double remainingWeight;

        public double WeightTotal
        {
            get => weightTotal;
            set => weightTotal = value;
        }

        public int Item
        {
            get => item;
            set => item = value;
        }

        public double WeightUnit
        {
            get => weightUnit;
            set => weightUnit = value;
        }
        public double CurrentWeight()
        {
            currentWeight = Item * WeightUnit;
            return currentWeight;
        }

        public double RemainingWeight()
        {
            remainingWeight = WeightTotal - CurrentWeight();
            return remainingWeight;
        }
    }
}
