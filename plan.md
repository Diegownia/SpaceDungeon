# Adventure game! 

- currently no bigger plan...
- Game should have the character creation
- Game should have chacter development elements
- Game should be written in C# although we might consider writing some parts in other languages just for the gist of it
- Game should be a simple text game with simple ASCII graphics, if at some point I think about moving to Avalonia or actual game engine just fucking kill me...
- Game should have have turn based combat I believe this will be easier to implement (will see about that)
- Some base building mechanincs, perhaps even crew management
- Story wise? I honestly don't know... Maybe some space bs? Fuck knows... 

## Some thoughts

- come up with a decent save/load system (maybe for the sake of simplicity look at darkest dungeon => game have like a central port which player can develop and it's their starting point)
- Enemy system (some sort of enemy database?) maybe later on come up with randomly generated enemies idk.
- Consider taking an engine for ASCII like GORogue or something

## Buildings

Buildings should pose more of a resource generation role, in order to grow your base you need to terraform the terrain, produce electricity, be able to provide building with oxygen etc. 
Ideally player would start with working HQ (however for the plot we might consider making the HQ broken - maybe a little tutorial?)
- HQ should be an operational Hub (mission control, statistics overview etc)
-- Should come with basic stuff like oxygen production, food production, electricity generation, living spaces, radar(WIP most likely mission controll, resource fnding)

### Oxygen Generation

When living in space it's important to remember about breathing... Some basic buildings should have a form of a re-breathers, rather than generating oxygen from scratch they will recyrculate exisiting atmosphere (if existing) into breathable air. This should only work for a limited amount of time, but consume smaller ammount of energy where as upgrading this system will provide increased efficiency giving player more time. 
When recyrculating air we need to consider that the amount of CO2 produced is about 1 kg per crewmember per day. For simplicity, we will use percenteges to calculate how CO2 affects people. (perks and statuses need to be considered later) Each building will have other dimensions and oxygen capacity need to considered individually. Now when it comes to managing people will assume they are stationary to heir posts, meaningthey will not be moving around the base at least initially. 

 

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
