using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TraitType
{
    Hermit = 0,
    Neighborly = 1,
    Ecologist = 2,
    Industrious = 3,
    Thrifty = 4,
    Prodigal = 5,
    Lazy = 6, 
    HardWorker = 7,
    Spendthrift = 8,
    Foodie = 9,
    Brewster = 10,
    NatureLover = 11,
    Artist = 12,
    Historian = 13,
    Crafty = 14,
    SkyHigh = 15,
    Gardener= 16,
    LawnmowerEnthusiast = 17
}

public class Trait
{
    public TraitType _traitType;
    public bool traitRevealed = false;

    Villager _villager;
    Tile _tile;
    Building _building;

    // Constructor
    public Trait(TraitType traitType, Villager villager)
    {
        _traitType = traitType;
        _villager = villager;
    }

    // Switch case for determining trait effect
    public void DoEffect()
    {
        if(_tile == null)
        {
            Debug.LogError(_villager.name + "'s Trait has no Tile reference!");
            return;
        }

        List<Building> surroundingBuildings = _tile.GetSurroundingBuildings();
        switch (_traitType)
        {
            case TraitType.Hermit:

                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    _villager.happiness -= 3; //per turn for adjacent House tiles
                }

                _villager.happiness += 4 * _tile.EmptySurroundingTilesCount(); //per turn for adjacent empty tiles

                break;

            case TraitType.Neighborly:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    _villager.happiness += 2; //per turn for adjacent House tiles
                }

                _villager.happiness -= 3 * _tile.EmptySurroundingTilesCount(); //per turn for adjacent empty tiles

                break;

            case TraitType.Ecologist:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._type == BuildingType.Recreational)
                    {
                        _villager.happiness += 5; //per turn for adjacent House tiles
                    }

                    if (_building._type == BuildingType.Industrial)
                    {
                        _villager.happiness -= 5; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.Industrious:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._type == BuildingType.Recreational)
                    {
                        _villager.happiness -= 5; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.Thrifty:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._type == BuildingType.Recreational)
                    {
                        _villager.happiness += 5; //per turn for adjacent House tiles
                    }

                    if (_building._type == BuildingType.Commercial)
                    {
                        _villager.happiness -= 5; //per turn for adjacent House tiles
                    }
                }
                break;

            //needs a special case in Building
            case TraitType.Prodigal:
                for(int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._type == BuildingType.Commercial)
                    {
                        _villager.happiness += 5; //per turn for adjacent House tiles
                    }

                    if (_building._type == BuildingType.Recreational)
                    {
                        _villager.happiness -= 5; //per turn for adjacent House tiles
                    }
                }
                break;


            case TraitType.Lazy:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._type == BuildingType.Commercial)
                    {
                        _villager.happiness += 5; //per turn for adjacent House tiles
                    }

                    if (_building._type == BuildingType.Industrial)
                    {
                        _villager.happiness -= 5; //per turn for adjacent House tiles
                    }
                }
                    break;

            //needs a special case in Building
            case TraitType.HardWorker:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._type == BuildingType.Industrial)
                    {
                        _villager.happiness += 5; //per turn for adjacent House tiles
                    }

                    if (_building._type == BuildingType.Commercial)
                    {
                        _villager.happiness -= 5; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.Spendthrift:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if(_building._name == "Market")
                    {
                        _villager.happiness += 10; //per turn for adjacent House tiles
                    }

                    if(_building._name == "Windmill")
                    {
                        _villager.happiness -= 10; //per turn for adjacent House tiles
                    }
                }
                    break;

            case TraitType.Foodie:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._name == "Restaurant")
                    {
                        _villager.happiness += 10; //per turn for adjacent House tiles
                    }

                    if (_building._name == "Shed")
                    {
                        _villager.happiness -= 10; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.Brewster:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._name == "Cafe")
                    {
                        _villager.happiness += 10; //per turn for adjacent House tiles
                    }

                    if (_building._name == "Library")
                    {
                        _villager.happiness -= 10; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.NatureLover:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._name == "Park")
                    {
                        _villager.happiness += 10; //per turn for adjacent House tiles
                    }

                    if (_building._name == "Workshop")
                    {
                        _villager.happiness -= 10; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.Artist:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._name == "Theater")
                    {
                        _villager.happiness += 10; //per turn for adjacent House tiles
                    }

                    if (_building._name == "Cafe")
                    {
                        _villager.happiness -= 10; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.Historian:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._name == "Library")
                    {
                        _villager.happiness += 10; //per turn for adjacent House tiles
                    }

                    if (_building._name == "Theater")
                    {
                        _villager.happiness -= 10; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.Crafty:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._name == "Workshop")
                    {
                        _villager.happiness += 10; //per turn for adjacent House tiles
                    }

                    if (_building._name == "Market")
                    {
                        _villager.happiness -= 10; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.SkyHigh:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._name == "Windmill")
                    {
                        _villager.happiness += 10; //per turn for adjacent House tiles
                    }

                    if (_building._name == "Restaurant")
                    {
                        _villager.happiness -= 10; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.Gardener:
                for (int b = 0; b < surroundingBuildings.Count; b++)
                {
                    if (_building._name == "Shed")
                    {
                        _villager.happiness += 10; //per turn for adjacent House tiles
                    }

                    if (_building._name == "Park")
                    {
                        _villager.happiness -= 10; //per turn for adjacent House tiles
                    }
                }
                break;

            case TraitType.LawnmowerEnthusiast:
                //TBA
                break;
        }
    }

}
