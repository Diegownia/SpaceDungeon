using AtmosphericCalculator.Models;

namespace AtmosphericCalculator;

public class PrintingService
{
    private readonly CalculationService _calculatorService;
    
    public PrintingService(CalculationService calculatorService)
    {
        _calculatorService = calculatorService;
    }
    
    public void PrintTotalAirMassOfBuilding(BuildingModel building)
    {
        var totalMass = _calculatorService.CalculateTotalAirMassPerBuilding(building);
        Console.WriteLine($"For a building with dimensions of: {building.Lenght} x {building.Width}");
        Console.WriteLine($"Total mass of air ine the building is: {totalMass} kg");
    }

    public void GetTotalMassOfElementsInBuilding(BuildingModel building)
    {
        var elementalMass = _calculatorService.CalculateElementsMassPerBuilding(building);
        Console.WriteLine($"For a building with dimensions of: {building.Lenght} x {building.Width}");
        Console.WriteLine("Total mass of each elements: ");
        Console.WriteLine($"{nameof(elementalMass.Nitrogen)}: [{elementalMass.Nitrogen}] kg");
        Console.WriteLine($"{nameof(elementalMass.Oxygen)}: [{elementalMass.Oxygen}] kg");
        Console.WriteLine($"{nameof(elementalMass.Argon)}: [{elementalMass.Argon}] kg");
        Console.WriteLine($"{nameof(elementalMass.CarbonDioxide)}: [{elementalMass.CarbonDioxide}] kg");
        Console.WriteLine("----------------------------------------------------");
        var totalMass = elementalMass.Nitrogen + elementalMass.Oxygen + elementalMass.Argon +
                        elementalMass.CarbonDioxide;
        Console.WriteLine($"In Total: {totalMass}");
    }
}