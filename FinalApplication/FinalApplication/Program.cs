using FinalApplication;

namespace FinalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Elevator elevator2 = new Elevator(3, 600);
            elevator1.AddOccupants("A1", 180, [0]);
            elevator1.AddOccupants("A2", 220, [1]);
            elevator1.IsOverMaxCapacity();
            elevator2.AddOccupants("A1", 200, [0]);
            elevator2.AddOccupants("A2", 200, [1]);
            elevator2.AddOccupants("A3", 201, [2]);
            elevator2.IsOverMaxCapacity();

            public bool elevator1IsOverMaxCapacity = false;
            public bool elevator2IsOverMaxCapacity = true;
    }
}
}
