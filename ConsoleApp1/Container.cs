namespace ConsoleApp1;

public class Container
{
    
    private static int ContIdAll = 0;
    private int ContId;
    private double mass;
    private double height;
    private double contMass;
    private double breadth;
    private string serialNumber;
    private double maxMass;

    public Container(double mass, double height, double contMass, double breadth, double maxMass)
    {
        this.ContId = ContIdAll;
        ContIdAll++;
        this.mass = mass;
        this.height = height;
        this.contMass = contMass;
        this.breadth = breadth;
        this.maxMass = maxMass;
        this.serialNumber = "KON-";
    }

    public void Fill(double mass, double height, double contMass, double breadth, string serialNumber, double maxMass)
    {
        this.mass = mass;
        this.height = height;
        this.contMass = contMass;
        this.breadth = breadth;
        this.serialNumber = serialNumber;
        this.maxMass = maxMass;
    }

    public double Unload()
    {
        double tmp = this.mass;
        this.mass = 0;
        return tmp;
    }

    public void Load(double mass)
    {
        double newMass = this.mass + mass;
        if (newMass > maxMass)
        {
            throw new OverfillException();
        }
        else
        {
            this.mass = newMass;
        }

    }

    public double GetMaxMass()
    {
        return this.maxMass;
    }
    
    public double GetMass()
    {
        return this.mass;
    }
    
    public int GetId()
    {
        return this.ContId;
    }

    public string GetSN()
    {
        return this.serialNumber;
    }

    public void setSN(string SN)
    {
        this.serialNumber = SN;
    }

    public void ChangeMass(double mass)
    {
        this.mass = mass;
    }
}

[Serializable]
class OverfillException : Exception
{
    public OverfillException(){}
}