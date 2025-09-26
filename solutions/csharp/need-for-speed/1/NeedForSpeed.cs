class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int speed;
    public int batteryDrain;
    public int distanceDriven;
    public int battery;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.battery = 100;
    }
    
    public bool BatteryDrained() => this.battery < this.batteryDrain ? true : false;

    public int DistanceDriven() => this.distanceDriven;

    public void Drive()
    {
        if (!BatteryDrained() && this.battery >= this.batteryDrain)
        {
            this.distanceDriven += this.speed;
            this.battery -= this.batteryDrain;
        }

    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);

}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();

            if (car.DistanceDriven() >= this.distance)
            {
                return true;
            }
        }
        return car.DistanceDriven() >= this.distance;
    }
}
