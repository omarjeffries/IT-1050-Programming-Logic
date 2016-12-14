using System;

namespace FinalApplication
{
    class Elevator
    {
        private double MaxWeight;
        Passenger[] Occupants;
        
        public Elevator (int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }

        public void AddOccupants (Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            return MaxWeight++;
        }

        public double IsOverMaxCapacity()
        {
            return (GetCurrentWeight);
        }

        
    }
}
