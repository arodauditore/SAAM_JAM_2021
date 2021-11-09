using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Task : MonoBehaviour
{
    [Header("Task 1 Attributes")]
    //public TaskTypeOne taskOne;
    public string taskDesc;
    public bool isTaskCompleted = false;
    public bool isTaskRevealed = false;

    //Lists
    public static List<Task> _completedTasks;

    //References
    public Villager _villager;
    [HideInInspector] public Trait _trait;
    [HideInInspector] public Building _building;

    public void OnTaskReveal()
    {
        isTaskRevealed = true;
    }

    public void OnTaskComplete()
    {
        _villager.happiness += 4;
        MoneyManager.money += 50;
    }

    public void TaskCompleteReward()
    {
        _villager.happiness += 4;
    }

    public void FirstTask(int trait)
    {

        switch (trait)
        {
            case 0:
                taskDesc = "Build one Park.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Park")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 1:
                taskDesc = "Build one Cafe";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Cafe")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 2:
                taskDesc = "Build one Recreational Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Recreational)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 3:
                taskDesc = "Build one Industrial Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Industrial)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 4:
                taskDesc = "Build one Recreational Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Recreational)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 5:
                taskDesc = "Build one Commercial Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Commercial)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 6:
                taskDesc = "Build one Commercial Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Commercial)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 7:
                taskDesc = "Build one Industrial Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Industrial)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 8:
                taskDesc = "Build one Park.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Market")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 9:
                taskDesc = "Build one Restaurant";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Restaurant")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 10:
                taskDesc = "Build one Cafe";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Cafe")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 11:
                taskDesc = "Build one Park.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Park")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

                case 12:
                    taskDesc = "Build one Theater";
                    foreach (Building building in GridManager._buildings)
                    {
                        if (building._name == "Theater")
                        {
                            isTaskCompleted = true;
                            _completedTasks.Add(this);
                            OnTaskComplete();
                        }
                    }
                    _villager._tasks.Add(this);
                break;

                case 13:
                    taskDesc = "Build one Library";
                    foreach (Building building in GridManager._buildings)
                    {
                        if (building._name == "Library")
                        {
                            isTaskCompleted = true;
                            _completedTasks.Add(this);
                            OnTaskComplete();
                        }
                    }
                    _villager._tasks.Add(this);
                break;

                case 14:
                    taskDesc = "Build one Workshop";
                    foreach (Building building in GridManager._buildings)
                    {
                        if (building._name == "Theater")
                        {
                            isTaskCompleted = true;
                            _completedTasks.Add(this);
                            OnTaskComplete();
                        }
                    }
                    _villager._tasks.Add(this);
                break;

                case 15:
                    taskDesc = "Build one Windmill.";
                    foreach (Building building in GridManager._buildings)
                    {
                        if (building._name == "Windmill")
                        {
                            isTaskCompleted = true;
                            _completedTasks.Add(this);
                            OnTaskComplete();
                        }
                    }
                    _villager._tasks.Add(this);
                break;

                case 16:
                    taskDesc = "Build one Shed.";
                    foreach (Building building in GridManager._buildings)
                    {
                        if (building._name == "Shed")
                        {
                            isTaskCompleted = true;
                            _completedTasks.Add(this);
                            OnTaskComplete();
                        }
                    }
                    _villager._tasks.Add(this);
                break;

                case 17:
                    taskDesc = "Build one Shed.";
                    foreach (Building building in GridManager._buildings)
                    {
                        if (building._name == "Shed")
                        {
                            isTaskCompleted = true;
                            _completedTasks.Add(this);
                            OnTaskComplete();
                        }
                    }
                    _villager._tasks.Add(this);
                break;
        }
    }
    public void SecondTask(int trait)
    {
        switch (trait)
        {
            case 0:
                taskDesc = "Build one Park.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Park")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 1:
                taskDesc = "Build one Cafe";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Cafe")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 2:
                taskDesc = "Build one Recreational Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Recreational)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 3:
                taskDesc = "Build one Industrial Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Industrial)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 4:
                taskDesc = "Build one Recreational Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Recreational)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 5:
                taskDesc = "Build one Commercial Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Commercial)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 6:
                taskDesc = "Build one Commercial Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Commercial)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 7:
                taskDesc = "Build one Industrial Building";
                foreach (Building building in GridManager._buildings)
                {
                    if (_building._type == BuildingType.Industrial)
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 8:
                taskDesc = "Build one Park.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Market")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 9:
                taskDesc = "Build one Restaurant";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Restaurant")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 10:
                taskDesc = "Build one Cafe";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Cafe")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 11:
                taskDesc = "Build one Park.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Park")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 12:
                taskDesc = "Build one Theater";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Theater")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 13:
                taskDesc = "Build one Library";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Library")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 14:
                taskDesc = "Build one Workshop";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Theater")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 15:
                taskDesc = "Build one Windmill.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Windmill")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 16:
                taskDesc = "Build one Shed.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Shed")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 17:
                taskDesc = "Build one Shed.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Shed")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;
        }
    }

    public void ThirdTask(int trait)
    {
        int b;
        switch (trait)
        {
            case 0:
                taskDesc = "Build one Park and the Infirmary.";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Park" && building._name == "Infirmary")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 1:
                taskDesc = "Build one Cafe and the Post Office";
                foreach (Building building in GridManager._buildings)
                {
                    if (building._name == "Cafe" && building._name == "Post Office")
                    {
                        isTaskCompleted = true;
                        _completedTasks.Add(this);
                        OnTaskComplete();
                    }
                }
                _villager._tasks.Add(this);
                break;

            case 2:
                taskDesc = "Build three Recreational Buildings";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._type == BuildingType.Recreational)
                    {
                        b = b + 1;
                    }
                }

                if (b >= 3)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 3:
                taskDesc = "Build three Industrial Buildings";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._type == BuildingType.Industrial)
                    {
                        b = b + 1;
                    }
                }

                if (b >= 3)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 4:
                taskDesc = "Build three Recreational Buildings";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._type == BuildingType.Recreational)
                    {
                        b = b + 1;
                    }
                }

                if (b >= 3)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 5:
                taskDesc = "Build three Commercial Buildings";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._type == BuildingType.Commercial)
                    {
                        b = b + 1;
                    }
                }

                if (b >= 3)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 6:
                taskDesc = "Build three Commercial Buildings";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._type == BuildingType.Commercial)
                    {
                        b = b + 1;
                    }
                }

                if (b >= 3)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 7:
                taskDesc = "Build three Industrial Buildings";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._type == BuildingType.Industrial)
                    {
                        b = b + 1;
                    }
                }

                if (b >= 3)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 8:
                taskDesc = "Build two Markets";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Market")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 9:
                taskDesc = "Build two Restaurants";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Restaurants")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 10:
                taskDesc = "Build two Cafes";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Cafe")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 11:
                taskDesc = "Build two Parks";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Park")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 12:
                taskDesc = "Build two Theaters";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Theater")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 13:
                taskDesc = "Build two Libraries";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Library")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 14:
                taskDesc = "Build two Workshops";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Workshop")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 15:
                taskDesc = "Build two Windmills";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Windmill")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 16:
                taskDesc = "Build two Sheds";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Shed")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;

            case 17:
                taskDesc = "Build two Sheds";
                b = 0;
                foreach (Building building in GridManager._buildings)
                {

                    if (_building._name == "Shed")
                    {
                        b = b + 1;
                    }
                }

                if (b >= 2)
                {
                    isTaskCompleted = true;
                    _completedTasks.Add(this);
                    OnTaskComplete();
                }
                _villager._tasks.Add(this);
                break;
        }
    }
}


