namespace ConsoleApp1;

public class ContainerGas : Container, IHazardNotifier
{
    private double pressure;
    
    public ContainerGas(double mass, double height, double contMass, double breadth, double maxMass, double pressure)
        :base(mass, height, contMass, breadth, maxMass)
    {
        this.pressure = pressure;
        string SN = GetSN() + "G-" + GetId();
        setSN(SN);
    }
    
    public void RelaySN()
    {
        Console.WriteLine(GetSN());
    }

    public void Unload()
    {
        double newMass = GetMass() * 0.05;
        ChangeMass(newMass);
    }
    
    public void Notify()
    {
        Console.WriteLine("Dangerous action");
    }
}