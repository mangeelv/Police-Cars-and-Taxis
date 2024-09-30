using Practice1;
using System;

public class PoliceStation
{
	private List<PoliceCar> policeList;
	public List<Vehicle> infractorsList = new List<Vehicle>();
	public bool alarm; 


	private void RegisterPoliceCar(PoliceCar policeCar)
	{
		policeList.Add(policeCar);
	}

	private void NotifyPoliceCar(PoliceCar policeCar)
	{
		PoliceCar.speedingCar = infractorsList.Last();

    }



}
