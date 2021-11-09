using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public double finalScore;

    public double financialScore;
    public double communityScore;
    //intermediary variables for community score calculation
    public double commHappyScore;
    public double commBuildScore;

    public double happyScore;

    [HideInInspector] public Building _building;

    public void CalculateFinancialScore() {
        financialScore = MoneyManager.money * 6.25;
    }

    public void CalculateHappyScore()
    {
        double totalHappy = 0;
        foreach(Villager villager in VillagerManager._revealedVillagers)
        {
            if(villager.happiness > 100)
            {
                villager.happiness = 100;
            }

            totalHappy = villager.happiness + totalHappy; 
        }

        commHappyScore = totalHappy * 50;

        happyScore = totalHappy * 100;
    }

    public void CalculateCommunityScore()
    {
        double uwuBuildingScore = 0;
        foreach (Building building in GridManager._buildings)
        {
            //I hate to do this but it's 3AM in the morning
            if (building._name == "Infirmary" || building._name == "School" || building._name == "Fire Station" || building._name == "Post Office" || building._name == "Bank" || building._name == "Police Station")
            {
                uwuBuildingScore = uwuBuildingScore + 12;
            }
        }
        commBuildScore = uwuBuildingScore * 50;

        communityScore = commBuildScore + commHappyScore;

    }

    public void CalculateFinalScore()
    {
        CalculateFinancialScore();
        CalculateHappyScore();
        CalculateCommunityScore();
        finalScore = financialScore + communityScore + happyScore;
    }

}

