using System;
using System.Collections.Generic;
using System.Text;

namespace _1050FinalLab
{
    class Elevator

    {
        private double MaxWeight;
        Passenger[] Occupants;
        private double TotalWeight;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int Index)
        {
            Occupants[Index] = passenger;
        }
        public double GetCurrentWeight()
        {

            foreach (Passenger passenger in Occupants)
            {

                double PassengerWeight = passenger.GetWeight();
                TotalWeight = PassengerWeight + TotalWeight;
                Console.WriteLine(TotalWeight);
            }

            return TotalWeight;

        }
        public bool IsOverMaxCapacity()
        {

            if (TotalWeight <= MaxWeight)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}