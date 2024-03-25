namespace ConsoleApp1;

public class ContainerSolid : Container
{
    private string product;
    private double temp;
    
    public ContainerSolid(double mass, double height, double contMass, double breadth, string serialNumber, double maxMass, string product, double temp)
        :base(mass, height, contMass, breadth, maxMass)
    {
        this.product = product;
        this.temp = temp;
        string SN = GetSN() + "S-" + GetId();
        setSN(SN);
    }
    
    public void RelaySN()
    {
        Console.WriteLine(GetSN());
    }


    public void checkTemp()
    {
        switch (product)
        {
            case "Bananas":
                if (temp < 13.3)
                    throw new TooColdException();
                break;
            case "Chocolate":
                if (temp < 18)
                    throw new TooColdException();
                break;
            case "Fish":
                if (temp < 2)
                    throw new TooColdException();
                break;
            case "Meat":
                if (temp < -15)
                    throw new TooColdException();
                break;
            
            default:

                break;
        }
    }

    

}

[Serializable]
class TooColdException : Exception
{
    public TooColdException(){}
}