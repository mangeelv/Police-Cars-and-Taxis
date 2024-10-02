namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            PoliceStation policeStation = new PoliceStation();
            Console.WriteLine(policeStation.WriteMessage("Created"));
            City city = new City(policeStation);
            Console.WriteLine(city.WriteMessage("Created"));
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Console.WriteLine(taxi2.WriteMessage("Created"));

            city.AddLicense(taxi1);
            city.AddLicense(taxi2);


            PoliceCar policeCar1 = new PoliceCar("0001 CNP",policeStation);
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            PoliceCar policeCar2 = new PoliceCar("0002 CNP", policeStation);
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            SpeedRadar radar = new SpeedRadar();
            policeCar2.SetSpeedRadar(radar);
      
         

            PoliceCar policeCar3 = new PoliceCar("0003 CNP", policeStation);
            Console.WriteLine(policeCar3.WriteMessage("Created"));
            SpeedRadar radar2 = new SpeedRadar();
            policeCar3.SetSpeedRadar(radar2);
            policeCar3.StartPatrolling();

            PoliceCar policeCar4 = new PoliceCar("0004 CNP", policeStation);
            Console.WriteLine(policeCar4.WriteMessage("Created"));
            SpeedRadar radar3 = new SpeedRadar();
            policeCar4.SetSpeedRadar(radar3);
            policeCar4.StartPatrolling();
            policeCar4.EndPatrolling();

            policeStation.RegisterPoliceCar(policeCar1);
            policeStation.RegisterPoliceCar(policeCar2);

            policeStation.RegisterPoliceCar(policeCar3);
            policeStation.RegisterPoliceCar(policeCar4);

            // intento de usar el radar en un coche de policía que no tiene radar
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);

            // pillamos a un vehículo por encima de la velocidad legal, avisamos al resto de coches patrolling
            taxi2.StartRide();
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();

            // quitamos licencia por sobrepasar la velocidad legal
            city.RemoveLicense(taxi2);
          

           

        }
    }
}
    

