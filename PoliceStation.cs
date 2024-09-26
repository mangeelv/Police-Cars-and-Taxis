using Practice1;
using System;

public class PoliceStation
{
	private List<PoliceCar> policeList;
	private List<Taxi> infractorsList;
	public bool alarm; 


	private void RegisterPoliceCar(PoliceCar policeCar)
	{
		policeList.Add(policeCar);
	}



}
