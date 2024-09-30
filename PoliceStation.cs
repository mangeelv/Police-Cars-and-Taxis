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
		
		PoliceCar.speedingCar = infractorsList.Last();
		
		}
    }




