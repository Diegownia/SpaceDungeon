# SpaceDungeon game! 

- currently no bigger plan...
- Some base building mechanics, perhaps even crew management
- Story for now needs to be simple, we just crashed on the surface of mars or perhaps other unknown planet, our station is somewhat broken and we will need to fix it solving some coding challenges

## Buildings

Buildings should pose more of a resource generation role, in order to grow your base you need to terraform the terrain, produce electricity, be able to provide building with oxygen etc. 
Ideally player would start with working HQ (however for the plot we might consider making the HQ broken - maybe a little tutorial?)
- HQ should be an operational Hub (mission control, statistics overview etc)
-- Should come with basic stuff like oxygen production, food production, electricity generation, living spaces, radar(WIP most likely mission controll, resource fnding)

### Oxygen Generation

When living in space it's important to remember about breathing... Some basic buildings should have a form of a re-breathers, rather than generating oxygen from scratch they will recyrculate exisiting atmosphere (if existing) into breathable air. This should only work for a limited amount of time, but consume smaller ammount of energy where as upgrading this system will provide increased efficiency giving player more time. 
When recirculating air we need to consider that the amount of CO2 produced is about 1 kg per crewmember per day. For simplicity, we will use percenteges to calculate how CO2 affects people. (perks and statuses need to be considered later) Each building will have other dimensions and oxygen capacity need to considered individually. Now when it comes to managing people will assume they are stationary to their posts, meaning they will not be moving around the base at least initially. 

 

### Human needs
- on average it is estimated that human need about 5 kilograms of food water and oxygen to perform day to day task:
-- 0.84 kg of oxygen
-- 0.62 kg of food
-- 3.54 kg of water

- CO2 limits
-- 0.10% reduced mental capacity 
-- 0.15-0.2% light drowsiness
-- 0.25% significant metnal capacity reduction
-- 0.3-0.5% nausea, complete lost of concentration
-- 1% Drowsiness
-- 2% Headaches, lowered intelligence
-- 4% oxygen deprivation 
-- 5% Toxic air, uncon, death...
