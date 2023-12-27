namespace AtmosphericCalculator.Models;

public class BuildingModel
{
    public decimal Lenght { get; set; }
    public decimal Width { get; set; }
    public decimal Volume => Lenght * Width * 3M;
}