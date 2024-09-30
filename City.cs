using Practice1;
using System;

public class City
{
	private PoliceStation policeStation;
	private List<Taxi> licensedTaxis = new List<Taxi>() ;


	private void AddLicense(Taxi taxi)
	{
		licensedTaxis.Add(taxi);
	}

	private void RemoveLicense(Taxi taxi)
	{
		licensedTaxis.Remove(taxi);
	}

	public City(PoliceStation policeStation)
    {
        this.policeStation = policeStation;
 
    }
}
