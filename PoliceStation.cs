using Practice1;
using System;

public class PoliceStation: IMessageWritter
{
	private List<PoliceCar> policeList = new List<PoliceCar>();
	public List<Vehicle> infractorsList = new List<Vehicle>();
	public bool alarm; 


	public void RegisterPoliceCar(PoliceCar policeCar)
	{
		policeList.Add(policeCar);
		Console.WriteLine(WriteMessage($"Police Car with plate {policeCar.GetPlate()} was registered in the Police Station"));
	}


	public void ActivateAlarm()
	{
		alarm = true;
        Console.WriteLine(WriteMessage("Alarm has been activated"));
    }
	public void NotifyPoliceCars()
	{
		
		foreach (PoliceCar policeCar in policeList)
		{
			if (policeCar.IsPatrolling()) // si está patrullando 
			{
				policeCar.SetSpeedingCar(infractorsList.Last().GetPlate()); // le notificamos el coche infractor 
				policeCar.SetChasing(true); // hemos notificado al coche de policia de que hay un vehículo por encima del límite
			}
		}
        Console.WriteLine(WriteMessage("All active police cars have been notified of the speeding car. The ones patrolling started the chase. "));

    }

    //Implment interface with Vechicle message structure
    public string WriteMessage(string message)
    {
        return $"{this}: {message}";
    }
}




