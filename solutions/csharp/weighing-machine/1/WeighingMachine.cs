using System.Globalization;
using System.Numerics;

class WeighingMachine
{
    public int Precision { get; private set; }
    public double TareAdjustment { get; set; } = 5;

    private double weight;
    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 0) { throw new ArgumentOutOfRangeException("value"); }
            weight = value;
        }
    }

    public string DisplayWeight
    {
        get
        {
            var format = new NumberFormatInfo() { NumberDecimalDigits = this.Precision };
       
            return (this.Weight - this.TareAdjustment).ToString("f",format) + " kg";
        }
    }

    public WeighingMachine(int precision) => this.Precision = precision;
}
