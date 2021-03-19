﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task6_8_Lib
{
    public class Tanker : CargoShip
    {
        public string TransportedLiquid { get; set; }

        public TankerType TankerType { get; set; }

        public Tanker(string name, float liftingCapacity, int numberOfStaff, string transportedLiquid, TankerType tankerType)
        {
            Name = name;
            LiftingCapacity = liftingCapacity;
            NumberOfStaff = numberOfStaff;
            TransportedLiquid = transportedLiquid;
            TankerType = tankerType;
        }

        public string RefuelShip(IShip ship)
        {
            return $"Танкер {Name} заправил корабль {ship.Name}";
        }

        public string SpillCargo()
        {
            return $"Танкер {Name} пролил груз";
        }

        public override string ToString()
        {
            return $"Танкер {Name} класса {TankerType} " +
                $"грузоподемностьб {LiftingCapacity} " +
                $"с персоналом в количестве {NumberOfStaff} перевозит {TransportedLiquid}.";
        }
    }
}
