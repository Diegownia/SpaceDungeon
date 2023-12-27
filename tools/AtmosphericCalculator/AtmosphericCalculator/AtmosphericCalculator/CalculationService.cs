using AtmosphericCalculator.Models;

namespace AtmosphericCalculator;

public class CalculationService
{
    public decimal CalculateTotalAirMassPerBuilding(BuildingModel building)
        => building.Volume * AirCompositionStaticModel.AirDensity;

    public AirModel CalculateElementsMassPerBuilding(BuildingModel building)
    {
        var air = CreateAirModel();
        int precision = 6;
        air.Nitrogen = Math.Round(building.Volume * (AirCompositionStaticModel.Nitrogen/100) * AirCompositionStaticModel.AirDensity, precision);
        air.Oxygen = Math.Round(building.Volume * (AirCompositionStaticModel.Oxygen/100) * AirCompositionStaticModel.AirDensity, precision);
        air.Argon = Math.Round(building.Volume * (AirCompositionStaticModel.Argon/100) * AirCompositionStaticModel.AirDensity, precision);
        air.CarbonDioxide = Math.Round(building.Volume * (AirCompositionStaticModel.CarbonDioxide/100) * AirCompositionStaticModel.AirDensity, precision);

        return air;
    }

    private AirModel CreateAirModel() => new AirModel();

}