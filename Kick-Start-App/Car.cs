using Microsoft.VisualBasic;

public class Car
{
    string vendor;
    string year;
    public string Model { get; set; }

    protected virtual void Test(int value)
    {
        var a = new ABC();
        var average = a.CalculateAverageAge(23, 12, 67);
    }
    
    protected void Test(string value)
    {
        var a = new ABC();
        var average = a.CalculateAverageAge(23, 12, 67);
    }
}
