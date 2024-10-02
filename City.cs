using Practice1;
using System;

public class City: IMessageWritter
{
	private PoliceStation policeStation;
	private List<Taxi> licensedTaxis = new List<Taxi>() ;


	public void AddLicense(Taxi taxi)
	{
		licensedTaxis.Add(taxi);
		Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} was given a license"));
	}

	public void RemoveLicense(Taxi taxi)
	{
		licensedTaxis.Remove(taxi);
        Console.WriteLine(WriteMessage($"Taxi with plate {taxi.GetPlate()} got his license taken away"));
    }

	public City(PoliceStation policeStation)
    {
        this.policeStation = policeStation;
 
    }


    //Implment interface with Vechicle message structure
    public string WriteMessage(string message)
    {
        return $"{this}: {message}";
    }
}



