using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum BuildingType
{
    Community,
    Industrial,
    Commercial,
    Recreational
}

public class Building : MonoBehaviour
{
    [Header("Building Attributes")]
    public string _name;
    public Sprite _sprite;
    public BuildingType _type;
    public int _cost;
    public int _quantity = -1;
    public string _description;
    public bool _occupied;

    [Header("Object References")]
    [HideInInspector] public Tile _tile;
    [HideInInspector] public Villager _villager;
    [HideInInspector] public GridManager _gridM;

    List<Building> _surroundingBuildings;

    public void Awake()
    {
        BuildManager.OnBuildingEnd += OnBuildEffect;
        Days.NextDayA += OnTurnEffect;
    }
    public void SurroundingBuildings()
    {
        List<Building> surrBuildings = _tile.GetSurroundingBuildings();
        _surroundingBuildings = surrBuildings;
    }

    public void BuildingActivate()
    {
        SurroundingBuildings();

        switch (_type)
        {
            //Community buildings
            case BuildingType.Community:
                if (_name != "House" || _name != "Town Hall")
                {
                    VillagerManager.GetRandomVillager().OnTraitReveal();
                }

                foreach (Villager villager in VillagerManager._revealedVillagers)
                {
                    villager.happiness += 5;  // Community Happiness Boost
                }

                OnBuildEffect();
                break;

            //Industrial buildings
            case BuildingType.Industrial:
                OnBuildEffect();
                OnTurnEffect();
                break;

            //Commercial Buildings
            case BuildingType.Commercial:
                OnTurnEffect();
                break;

            //Recreational buildings
            case BuildingType.Recreational:
                OnBuildEffect();
                OnTurnEffect();
                break;
        }
    }

    public void OnBuildEffect()
    {
        SurroundingBuildings();

        //The Town Hall has no effects, so we'll skip it.
        if (_name == "Town Hall") return;

        //A house upon being built will house the first village in the _revealedVillagers list.
        if (_name == "House")
        {
            foreach(Villager villager in VillagerManager._revealedVillagers)
            {
                if(villager.housed == false)
                {
                    villager.housed = true;
                    _occupied = true;
                    VillagerManager._housedVillagers.Add(villager);
                    _villager = villager;
                    break;
                }
            }
        }

        switch (_name)
        {
            //Community Buildings-------------------------------
            case "School":
                foreach (Villager villager in VillagerManager._revealedVillagers)
                {
                    villager.happiness += 15;  // Community Happiness Boost
                }
                break;

            case "Bank":
                MoneyManager.money += 50;
                break;

            //Recreational Buildings-------------------------------
            case "Park":
                foreach (Building building in _surroundingBuildings)
                {
                    if (building._name == "House" && (!_villager.hasTrait(TraitType.Industrious) || !_villager.hasTrait(TraitType.Prodigal)))
                    {
                        building._villager.happiness += 10; //static happiness boost on build
                    }
                }
                break;
            case "Theater":
                foreach (Building building in _surroundingBuildings)
                {
                    if (building._name == "House" && (!_villager.hasTrait(TraitType.Industrious) || !_villager.hasTrait(TraitType.Prodigal)))
                    {
                        building._villager.happiness += 15; //static happiness boost on build
                    }
                }
                break;
            case "Library":
                foreach (Building building in _surroundingBuildings)
                {
                    if (building._name == "House" && (!_villager.hasTrait(TraitType.Industrious) || !_villager.hasTrait(TraitType.Prodigal)))
                    {
                        building._villager.happiness += 20; //static happiness boost on build
                    }
                }
                break;

            //Industrial Buildings-------------------------------------
            case "Workshop":
                foreach (Building building in _surroundingBuildings)
                {
                    if (building.name != "House") break;

                    if (building._name == "House" && (!_villager.hasTrait(TraitType.Industrious) || !_villager.hasTrait(TraitType.HardWorker)))
                    {
                        building._villager.happiness -= 12; //static happiness boost on build
                    }

                    if (building._villager.hasTrait(TraitType.Industrious) || building._villager.hasTrait(TraitType.HardWorker))
                    {
                        building._villager.happiness += 20;
                    }
                }
                break;
            case "Windmill":
                foreach (Building building in _surroundingBuildings)
                {
                    if (building.name != "House") break;

                    if (building._name == "House" && (!_villager.hasTrait(TraitType.Industrious) || !_villager.hasTrait(TraitType.HardWorker)))
                    {
                        building._villager.happiness -= 17; //static happiness boost on build
                    }

                    if(building._villager.hasTrait(TraitType.Industrious) || building._villager.hasTrait(TraitType.HardWorker))
                    {
                        building._villager.happiness += 15; 
                    }
                }
                break;
            case "Shed":
                foreach (Building building in _surroundingBuildings)
                {
                    if (building.name != "House") break;

                    if (building._name == "House" && (!_villager.hasTrait(TraitType.Industrious) || !_villager.hasTrait(TraitType.HardWorker)))
                    {
                        building._villager.happiness -= 22; //static happiness boost on build
                    }

                    if (building._villager.hasTrait(TraitType.Industrious) || building._villager.hasTrait(TraitType.HardWorker))
                    {
                        building._villager.happiness += 10;
                    }
                }
                break;
        }
    }

    public void OnTurnEffect()
    {
        SurroundingBuildings();

        switch (_name)
        {
            //Industrial Buildings------------------------------
            case "Workshop":
                MoneyManager.money += 40; //per turn
                foreach (Building building in _surroundingBuildings)
                {
                    if (building.name != "House") break;

                    if (building._name == "House" && (!_villager.hasTrait(TraitType.Industrious) || !_villager.hasTrait(TraitType.HardWorker)))
                    {
                       building._villager.happiness -= 10; //per turn for adjacent House tiles
                    }

                    if (building._villager.hasTrait(TraitType.Industrious) || building._villager.hasTrait(TraitType.HardWorker))
                    {
                        building._villager.happiness += 10;
                    }
                }
                break;

            case "Windmill":
                MoneyManager.money += 25; //per turn
                foreach (Building building in _surroundingBuildings)
                {
                    if (building.name != "House") break;

                    if (building._name == "House" && (!_villager.hasTrait(TraitType.Industrious) || !_villager.hasTrait(TraitType.HardWorker)))
                    {
                        building._villager.happiness -= 5; //per turn for adjacent House tiles
                    }

                    if (building._villager.hasTrait(TraitType.Industrious) || building._villager.hasTrait(TraitType.HardWorker))
                    {
                        building._villager.happiness += 5;
                    }
                }
                break;

            case "Shed":
                MoneyManager.money += 10; //per turn
                foreach (Building building in _surroundingBuildings)
                {
                    if (building.name != "House") break;

                    if (building._name == "House" && (!_villager.hasTrait(TraitType.Industrious) || !_villager.hasTrait(TraitType.HardWorker)))
                    {
                        building._villager.happiness -= 2; //per turn for adjacent House tiles
                    }

                    if (building._villager.hasTrait(TraitType.Industrious) || building._villager.hasTrait(TraitType.HardWorker))
                    {
                        building._villager.happiness += 2;
                    }
                }

                break;

            //Commercial Buildings-------------------------------
            case "Market":
                MoneyManager.money += 15; //per turn
                foreach (Building building in _surroundingBuildings)
                {
                    if (building._name == "Market")
                    {
                        MoneyManager.money += 4;
                    }

                    if (building._name == "House" && (!building._villager.hasTrait(TraitType.Thrifty) || !building._villager.hasTrait(TraitType.HardWorker)))
                    {
                        building._villager.happiness += 5; //per turn for adjacent House tiles
                    }
                }
                break;

            case "Restaurant":
                MoneyManager.money += 10; //per turn

                foreach (Building building in _surroundingBuildings)
                {
                    if (building._name == "House" && (!building._villager.hasTrait(TraitType.Thrifty) || !building._villager.hasTrait(TraitType.HardWorker)))
                    {
                        building._villager.happiness += 10; //per turn for adjacent House tiles
                    }
                }
                break;

            case "Cafe":
                MoneyManager.money += 5; //per turn

                foreach (Building building in _surroundingBuildings)
                {
                    if (building._name == "House" && building._name == "Cafe")
                    {
                        building._villager.happiness += 2; //per turn for adjacent House tiles
                    }

                    if (building._name == "House" && (!building._villager.hasTrait(TraitType.Thrifty) || !building._villager.hasTrait(TraitType.HardWorker)))
                    {
                        building._villager.happiness += 15; //per turn for adjacent House tiles
                    }

                }
                break;

            //Recreational Buildings-------------------------------
            case "Park":
                foreach (Building building in _surroundingBuildings)
                {
                    if (building.name != "House") break;

                    if (!building._villager.hasTrait(TraitType.Industrious) || !building._villager.hasTrait(TraitType.Prodigal))
                    {
                        building._villager.happiness += 2;  //per turn for adjacent House tiles
                    }
                }
                break;
            case "Theater":
                foreach (Building building in _surroundingBuildings)
                {
                    if (building.name != "House") break;

                    if (!building._villager.hasTrait(TraitType.Industrious) || !building._villager.hasTrait(TraitType.Prodigal))
                    {
                        building._villager.happiness += 5;  //per turn for adjacent House tiles
                    }
                }
                break;
            case "Library":
                foreach (Building building in _surroundingBuildings)
                {
                    if (building.name != "House") break;

                    if (!building._villager.hasTrait(TraitType.Industrious) || !building._villager.hasTrait(TraitType.Prodigal))
                    {
                        building._villager.happiness += 10;  //per turn for adjacent House tiles
                    }
                }
                break;
        }
    }

}

