using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exception = System.Exception;

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
            try
            {
                currentWeight = Item * WeightUnit;
                return currentWeight;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public double RemainingWeight()
        {
            try
            {
                remainingWeight = WeightTotal - CurrentWeight();
                return remainingWeight;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
