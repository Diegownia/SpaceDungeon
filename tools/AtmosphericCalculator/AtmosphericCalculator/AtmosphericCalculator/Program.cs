// See https://aka.ms/new-console-template for more information

using AtmosphericCalculator;
using AtmosphericCalculator.Models;

var app = new PrintingService(new CalculationService());

var building = new BuildingModel();

//TODO cleanup!
BuildingModel CreateBuilding()
{
    var building = new BuildingModel();
    building.Lenght = decimal.Parse(args[0]);
    building.Width = decimal.Parse(args[1]);
    return building;
}

app.PrintTotalAirMassOfBuilding(CreateBuilding());
app.GetTotalMassOfElementsInBuilding(CreateBuilding());