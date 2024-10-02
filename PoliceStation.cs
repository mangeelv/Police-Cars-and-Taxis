using Practice1;
using System;

public class PoliceStation
{
	private List<PoliceCar> policeList = new List<PoliceCar>();
	public List<Vehicle> infractorsList = new List<Vehicle>();
	public bool alarm; 


	private void RegisterPoliceCar(PoliceCar policeCar)
	{
		policeList.Add(policeCar);
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
		
		}
    }




