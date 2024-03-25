namespace ConsoleApp1;

public class ContainerLiquid : Container, IHazardNotifier
{
    private bool safe;
    
    public ContainerLiquid(double mass, double height, double contMass, double breadth, double maxMass, bool safe)
    :base(mass, height, contMass, breadth, maxMass)
    {
        this.safe = safe;
        string SN = GetSN() + "L-" + GetId();
        setSN(SN);
    }

    public void RelaySN()
    {
        Console.WriteLine(GetSN());
    }

    public void Load(double mass)
    {
        double control = 0;
        
        if (safe)
        {
            control = 0.9;
        }
        else
        {
            control = 0.5;
        }
        
        double newMass = GetMass() + mass;
        
        if (newMass > GetMaxMass())
        {
            throw new OverfillException();
        }
        else
        {
            if (newMass > GetMaxMass() * control)
            {
                Notify();
                newMass = GetMaxMass() * control;
            }
            ChangeMass(newMass);
        }
    }
    public void Notify()
    {
        Console.WriteLine("Dangerous action");
    }
}