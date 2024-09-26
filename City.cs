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

	public City(PoliceStation policeStation)
    {
        this.policeStation = policeStation;
 
    }
}
