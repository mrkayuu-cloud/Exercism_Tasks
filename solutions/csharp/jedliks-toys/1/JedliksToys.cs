class RemoteControlCar
{

    private int _distanceMeters= 0;
    private int _batteryCharge = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar(); 
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distanceMeters} meters";
    }

    public string BatteryDisplay()
    {
        if (this._batteryCharge == 0)
        {
            return "Battery empty";
        }
        else
            {
                return $"Battery at {_batteryCharge}%";
            }
    }

    public void Drive()
    {
        if (this._batteryCharge > 0)
        {
            this._distanceMeters += 20;
            this._batteryCharge -= 1;   
        }
    }
}
