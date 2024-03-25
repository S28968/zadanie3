namespace ConsoleApp1;

public class Ship
{

    private static int shipIdAll = 0;
    private int shipId;
    private Container[] Cargo;
    private double maxSpeed;
    private int maxSize;
    private int maxWeight;

    public Ship(Container[] Cargo, double maxSpeed, int maxSize, int maxWeight)
    {
        this.shipId = shipIdAll;
        shipIdAll++;
        this.Cargo = Cargo;
        this.maxSpeed = maxSpeed;
        this.maxSize = maxSize;
        this.maxWeight = maxWeight;
    }
    
    public Ship(double maxSpeed, int maxSize, int maxWeight)
    {
        this.maxSpeed = maxSpeed;
        this.maxSize = maxSize;
        this.maxWeight = maxWeight;
    }

    public void LoadSingle(Container cont)
    {
        if (Cargo == null)
        {
            Container[] newCargo = { cont };
            this.Cargo = newCargo;
        }
        
        int newSize = Cargo.Length + 1;
        if(newSize>maxSize)
            throw new TooFullException();



        {
            Container[] temp = new Container[newSize];
            for (int i = 0; i < newSize; i++)
            {
                if (i < Cargo.Length)
                {
                    temp[i] = Cargo[i];
                }
                else
                {
                    temp[i] = cont;
                }
            }

            this.Cargo = temp;

        }
    }

    public void LoadList(Container[] contList)
    {
        for (int i = 0; i < contList.Length; i++)
        {
            LoadSingle(contList[i]);
        }
        
    }

    public Container[] Unload()
    {
        return Cargo;
    }

    public void ChangeContainer(Container cont)
    {
        for (int i = 0; i < Cargo.Length; i++)
        {
            if ((cont.GetSN()).Equals(Cargo[i].GetSN()))
            {
                Cargo[i] = cont;
            }
        }
    }

    public void MoveBetweenShips(string SN, Ship ship)
    {
        /*
        for (int i = 0; i < Cargo.Length; i++)
        {
            if (SN.Equals(Cargo[i].GetSN()))
            {
                Ship.LoadSingle(Cargo[i]);
                Cargo[i] = null;
            }
        }
        */
       
    }
    

    public void deleteCargo(string SN)
    {
        for (int i = 0; i < Cargo.Length; i++)
        {
            if (SN.Equals(Cargo[i].GetSN()))
            {
                
                Cargo[i] = null;
            }
        }
    }
    
    
    
    
}

class TooFullException : Exception
{
    public TooFullException(){}
}
