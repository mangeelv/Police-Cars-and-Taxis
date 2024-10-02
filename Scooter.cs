using Practice1;
using System;

public class Scooter : Vehicle
{
    private const string typeOfVehicle = "Scooter";

    // Constructor de Scooter, llamando al constructor base de Vehicle
    public Scooter() : base(typeOfVehicle, string.Empty) // Pasas "Scooter" como el tipo y una matrícula vacía
    {
    }

    public override string GetPlate()
    {
       
        return "Los patinetes no tienen matrícula";
    }
}
