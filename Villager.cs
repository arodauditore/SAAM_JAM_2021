using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Villager : MonoBehaviour
{
    [Header("Villager Attributes")]
    public new string name;
    public Sprite portrait;
    public List<Task> _tasks = new List<Task>();
    public List<Trait> _traits = new List<Trait>();
    public int happiness = 50;
    public bool housed = false;

    // traitList holds all possible Traits for this Villager.
    List<TraitType> traitList = new List<TraitType>();

    //List<Tasks> taskListOne = new List<Tasks>();
    //List<Tasks> taskListTwo = new List<Tasks>();
    //List<Tasks> taskListThree = new List<Tasks>();

    public Task taskCall;

    private void Awake()
    {
        VillagerManager._allVillagers.Add(this);
    }

    public void Start()
    {
        //Add all TraitTypes to traitList
        foreach(TraitType t in Enum.GetValues(typeof(TraitType)))
        {
            traitList.Add(t);
        }

        AddTraits();
    }

    public bool hasTrait(TraitType owoTraitType)
    {
        foreach (Trait oneTrait in _traits)
        {
            if(owoTraitType == oneTrait._traitType)
            {
                return true;
            }
        }
        return false;
    }

    public void OnVillagerReveal()
    {
        VillagerManager._revealedVillagers.Add(this);
        _traits[0].traitRevealed = true;
    }

    public void OnTraitReveal()
    {

        if (_traits[1].traitRevealed == true)
        {
            _traits[2].traitRevealed = true;
        }

        if (_traits[0].traitRevealed == true)
        {
            _traits[1].traitRevealed = true;
        }
    }

    //Randomly generates three traits for this Villager. This is done so all three traits can be rolled at once whenever AddTrait() is called.
    //This accommodates for any future YarnSpinner/narrative design plans implementation
    public void AddTraits()
    {
            int traitIndex = UnityEngine.Random.Range(0, traitList.Count);
            _traits.Add(new Trait(traitList[traitIndex], this));
            print(traitList[traitIndex]);
        Debug.Log("taskCall null?" + (taskCall == null));
            taskCall.FirstTask(traitIndex);
            ExcludeIncompatibleTrait(traitList[traitIndex]);

            traitIndex = UnityEngine.Random.Range(0, traitList.Count);
            _traits.Add(new Trait(traitList[traitIndex], this));
            print(traitList[traitIndex]);
            taskCall.SecondTask((int)traitList[traitIndex]);
            ExcludeIncompatibleTrait(traitList[traitIndex]);

            traitIndex = UnityEngine.Random.Range(0, traitList.Count);
            _traits.Add(new Trait(traitList[traitIndex], this));
            print(traitList[traitIndex]);
            taskCall.ThirdTask((int)traitList[traitIndex]);
            ExcludeIncompatibleTrait(traitList[traitIndex]);
    }

    //Removes any TraitTypes from traitList that interfere with the given Trait.
    public void ExcludeIncompatibleTrait(TraitType trait)
    {

        switch (trait)
        {
            case TraitType.Hermit:
                traitList.Remove(TraitType.Hermit);
                traitList.Remove(TraitType.Neighborly);
                break;

            case TraitType.Neighborly:
                traitList.Remove(TraitType.Hermit);
                traitList.Remove(TraitType.Neighborly);
                break;

            case TraitType.Ecologist:
                traitList.Remove(TraitType.Ecologist);
                traitList.Remove(TraitType.Industrious);
                traitList.Remove(TraitType.HardWorker);
                break;

            case TraitType.Industrious:
                traitList.Remove(TraitType.Ecologist);
                traitList.Remove(TraitType.Industrious);
                traitList.Remove(TraitType.Thrifty);
                break;

            case TraitType.Thrifty:
                traitList.Remove(TraitType.Thrifty);
                traitList.Remove(TraitType.Prodigal);
                traitList.Remove(TraitType.Lazy);
                break;

            case TraitType.Prodigal:
                traitList.Remove(TraitType.Thrifty);
                traitList.Remove(TraitType.Prodigal);
                traitList.Remove(TraitType.Ecologist);
                break;

            case TraitType.Lazy:
                traitList.Remove(TraitType.Lazy);
                traitList.Remove(TraitType.HardWorker);
                traitList.Remove(TraitType.Industrious);
                break;

            case TraitType.HardWorker:
                traitList.Remove(TraitType.Lazy);
                traitList.Remove(TraitType.HardWorker);
                traitList.Remove(TraitType.Prodigal);
                break;

            case TraitType.Spendthrift:
                traitList.Remove(TraitType.Spendthrift);
                traitList.Remove(TraitType.Crafty);
                traitList.Remove(TraitType.SkyHigh);
                break;

            case TraitType.Foodie:
                traitList.Remove(TraitType.Foodie);
                traitList.Remove(TraitType.SkyHigh);
                traitList.Remove(TraitType.Gardener);
                break;

            case TraitType.Brewster:
                traitList.Remove(TraitType.Brewster);
                traitList.Remove(TraitType.Artist);
                traitList.Remove(TraitType.Historian);
                break;

            case TraitType.NatureLover:
                traitList.Remove(TraitType.NatureLover);
                traitList.Remove(TraitType.Crafty);
                traitList.Remove(TraitType.Gardener);
                break;

            case TraitType.Artist:
                traitList.Remove(TraitType.Artist);
                traitList.Remove(TraitType.Historian);
                traitList.Remove(TraitType.Brewster);
                break;

            case TraitType.Historian:
                traitList.Remove(TraitType.Historian);
                traitList.Remove(TraitType.Brewster);
                traitList.Remove(TraitType.Artist);
                break;

            case TraitType.Crafty:
                traitList.Remove(TraitType.Crafty);
                traitList.Remove(TraitType.NatureLover);
                traitList.Remove(TraitType.Spendthrift);
                break;

            case TraitType.SkyHigh:
                traitList.Remove(TraitType.SkyHigh);
                traitList.Remove(TraitType.Spendthrift);
                traitList.Remove(TraitType.Foodie);
                break;

            case TraitType.Gardener:
                traitList.Remove(TraitType.Gardener);
                traitList.Remove(TraitType.Foodie);
                traitList.Remove(TraitType.NatureLover);
                break;

            case TraitType.LawnmowerEnthusiast:
                traitList.Remove(TraitType.LawnmowerEnthusiast);
                traitList.Remove(TraitType.Foodie);
                traitList.Remove(TraitType.Lazy);
                traitList.Remove(TraitType.Ecologist);
                break;
        }

    }

}
