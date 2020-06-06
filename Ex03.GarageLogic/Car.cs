﻿namespace Ex03.GarageLogic
{
    class Car : Vehicle
    {
        private VehiclesEnums.eColor m_Color;
        private VehiclesEnums.eNumberOfDoors m_NumberOfDoors;
        private const int k_CarNumberOfWheels = 4;
        private const float k_CarMaxPressure = 32f;

        // C'TOR :
        public Car(string i_LicenseNumber, Engine i_Engine) : base(i_LicenseNumber, i_Engine)
        {
            initializeTires(k_CarMaxPressure, k_CarNumberOfWheels);
        }

        // PROPERTIES :
        public VehiclesEnums.eNumberOfDoors NumberOfDoors
        {
            set { m_NumberOfDoors = value; }
            get { return m_NumberOfDoors; }
        }

        public VehiclesEnums.eColor Color
        {
            set { m_Color = value; }
            get { return m_Color; }
        }
    }
}