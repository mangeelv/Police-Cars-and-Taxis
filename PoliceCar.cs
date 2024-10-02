namespace Practice1
{
    public class PoliceCar : Vehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private SpeedRadar speedRadar;
        public  string? speedingCarPlate; // no es estática ya que tenerla implica que el coche está patrullando
        private PoliceStation policeStation;
        private bool chasing = false;



        public PoliceCar(string plate, PoliceStation station) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            speedRadar = new SpeedRadar();
            policeStation = station;
        }

        public void SetChasing(bool chasingValue)
        {
            chasing = chasingValue;
        }

        public void SetSpeedingCar(string plate)
        {
            speedingCarPlate = plate;
        }


        private void ActivateAlarm()
        {
            policeStation.alarm = true;
        }
        public void UseRadar(Vehicle vehicle)
        {
            if (isPatrolling)
            {
                speedRadar.TriggerRadar(vehicle);
                string meassurement = speedRadar.GetLastReading();
                if (float.Parse(meassurement) > speedRadar.legalSpeed)
                {
                    ActivateAlarm();
                    policeStation.infractorsList.Add(vehicle); // Proporcionamos a la comisaría el infractor 
                    policeStation.NotifyPoliceCars();  // notificamos desde la comisarría al resto de coches de policía 
                    SetChasing(true); // como se ha detectado un vehículo por encima del límite empezamos el chasing
                    chasing = true;
                    
                }

                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            Console.WriteLine(WriteMessage("Report radar speed history:"));
            foreach (float speed in speedRadar.SpeedHistory)
            {
                Console.WriteLine(speed);
            }
        }
    }
}