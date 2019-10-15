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
        public double currentWeight { get; set; }
        private double remainingWeight;

        public Refrigerator()
        {

        }

        public Refrigerator(int item,double weightUnit)
        {
            this.item = item;
            this.weightUnit = weightUnit;
        }
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
        List<double> currentWeights=new List<double>();


        //public void CurrentWeights()
        //{
        //    double cw = Item * WeightUnit;
        //    currentWeights.Add(cw);
        //    //double cWeight=currentWeights.Sum();
        //    //return cWeight;
        //}
        public double CurrentWeight()
        {
            double cw = Item * WeightUnit;
            currentWeights.Add(cw);
            double cws=currentWeights.Sum();
            return cws;
        }

        public double CwList()
        {
            return currentWeights.Sum();
        }

        public double RemainingWeight()
        {
            try
            {
                remainingWeight = WeightTotal - currentWeights.Sum();
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
