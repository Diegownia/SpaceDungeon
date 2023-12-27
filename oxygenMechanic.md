# Oxygen mechanic details
This specific document will be focusing on the oxygen generation, recylculation, and management in greater detail

## Buildings

When creating a building user will have to define the building area, for example a 5x5 building => 25 sqM we now need to calculate how much air can be contained in that building for the simplicity of calculation we won't be building up, and by default each building will be 3 meters tall which gives us 75 cm with approximate air density of 1.204 kg/cm we should have about 90.3 kg of air. Now it's important to rember air composition which is:


|Element |Amount |
|--------|-------|
|Nitrogen|78.084%|
|Oxygen  |20.948%|
|Argon   |00.934%|
|CO2     |00.04% |

We will skip other elements for their trace values. For the purpose of calculating mass values of each elements per building a prototype calculator needs to be build, later on it will function as a service for checking these values in game ran every 5 seconds to trace changes in the ecosystem.

## Life Support
Basic life support (accessible from start) will work in a way tah it will slowly recycle CO2 into a breathable O2 in other words we need to consider that a building is a closed environment where a person will slowly take out the oxygen (around 1kg/day) and generate CO2 now this might require some better simulation but in essence if we had 100 kg of oxygen and 0.002 kg of CO2 in the room at the end of the day we should have 99 kg of Oxygen and 1.002 kg of CO2 in the room, now with these values it's already becoming difficult to breathe in that room since the amount of CO2 exceed 1% mark causing our crewmember to feel drowsiness.

Basic life support equipment should be able to process that 1kg of CO2 over the time of 24 hours (these values are simplified as in fact the amount of CO2 breathing out is roughly 4%) but we will be looking at it from a 24 h perspective to avoid unnecessary calculations. Since Life support doesn't only focus on CO2 but has to filter through the whole air we need to consider throughtput for the entire building let's have a look at our example building of 5x5x3 => with around 90.3 kg ideal life support should be able to filter through 100 kg of air per day 5 x 5 building is yet very small but it works for a minimal working space, therefore we will accept it. 

For later upgrades we can consider moving up to 500 kg of air per day this however have to include power consumption which we will look into later intial Life Support should look something like this:
1) Basic Life Support System - Filtering capacity: 100kg/day - Efficiency: 80% - Power consumption: 0.4kW/cm
Explanation:
Our BLSS is capable of filtering around 100kg of air per day, however when we get to the power consumption things can get interesting as for the base efficiency of 80% we consume 0.4 (0.5 real power drain) per cubic meter meaning to filter 25 cubic meters we will consume 12.5 kW/day therefore electricity needs to be represented in kW/hour value. Efficiency in Life Support Systems should be going down fairly quickly as they should be temporary equipment. With Efficiency going down it means that with taking the same power drain we will be recycling less and less air per day. On average we might consider that a daily decay is about 2% giving us some slack (after around 5 days the device should be converting less than 90kg of air meaning we might run into problems)

2) Industrial Life Support System - Filtering Capacity: 400kg/day - Efficiency: 88% - Power consumption 0.6kW/cubicmeter

3) SpaceGrade Life Support System - Filtering Capacity: 1000kg/day - Efficiency: 92% - Power consumption 0.7 kW/cubicMeter (slower decay maybe 1% a day)

now this is still to be considered and perhaps a simulation should tell us if these filtering values are good enough => extend Atmospheric Calculator to see different Life Support in action for initial settings use our example building with just one crewmember monitor power consumption and air composition throughout a month.

## Portable life support
WIP
