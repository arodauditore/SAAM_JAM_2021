using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public static class Days
{
    public delegate void NextDay();
    public static event NextDay NextDayA; // triggers number methods (happiness, money)
    public static event NextDay NextDayB; // triggers display methods (UI)

    public static int dayCount = 1;

    //[HideInInspector] public Villager _villager;
    //[HideInInspector] public Building _building;
    //[HideInInspector] public Scoring _score;
    //[HideInInspector] public Task _tasks;
    //[HideInInspector] public Trait _trait;

    //public TextMeshProUGUI dayCounterDisplay;
    //public TextMeshProUGUI moneyCounterDisplay;

    //references


    //essentially a main function to centralize everything
    public static void IncrementDay()
    {
        dayCount++;

        if(NextDayA != null)
            NextDayA();

        if(dayCount == 15)
        {
            //change scenes to end result scene Still needs code here!
            //if FinalScore > something, then good ending, else, bad ending??? Or something like that...

            //_score.CalculateFinalScore();
        }
        else
        {
            foreach (Villager villager in VillagerManager._revealedVillagers)
            {
                MoneyManager.money += 100;
            }

            VillagerAndTaskReveal();

            //TaskCompletion();
            //_building.OnTurnEffect();
            //_trait.DoEffect();

        }

        if (NextDayB != null)
            NextDayB();
    }


    public static void VillagerAndTaskReveal()
    {
        switch (dayCount)
        {
            case 1:
                VillagerManager._allVillagers[0].OnVillagerReveal();
                break;

            case 2:
                VillagerManager._allVillagers[1].OnVillagerReveal();
                break;

            case 3:
                VillagerManager._allVillagers[0]._tasks[0].OnTaskReveal();
                break;

            case 4:
                VillagerManager._allVillagers[2].OnVillagerReveal();
                break;

            case 5:
                VillagerManager._allVillagers[1]._tasks[0].OnTaskReveal();
                break;

            case 6:
                VillagerManager._allVillagers[2]._tasks[0].OnTaskReveal();
                break;

            case 7:
                VillagerManager._allVillagers[0]._tasks[1].OnTaskReveal();
                break;

            case 8:
                VillagerManager._allVillagers[1]._tasks[1].OnTaskReveal();
                break;

            case 10:
                VillagerManager._allVillagers[2]._tasks[1].OnTaskReveal();
                break;

            case 11:
                VillagerManager._allVillagers[0]._tasks[2].OnTaskReveal();
                break;

            case 12:
                VillagerManager._allVillagers[1]._tasks[2].OnTaskReveal();
                break;

            case 13:
                VillagerManager._allVillagers[2]._tasks[2].OnTaskReveal();
                break;
        }

    }

    /*
    public void TaskCompletion()
    {
        if(_tasks.isTaskCompleted == false)
        {
            _villager.happiness -= 5;
        }
        else
        {
            _tasks.TaskCompleteReward();
        }
    }
    */
}
