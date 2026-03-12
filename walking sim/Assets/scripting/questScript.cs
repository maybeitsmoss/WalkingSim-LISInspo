using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objectives")]
public class questScript : ScriptableObject
{
    public string currentObjective;
    public string objectiveName;
    public string objectiveDescription;
    public List<ToDo> objectives;

    private void OnEnable()
    {
        if (string.IsNullOrEmpty(currentObjective))
        {
            currentObjective = objectiveName + Guid.NewGuid().ToString();
        } 
    }

    [System.Serializable]

    public class ToDo
    {
        public string currentObjective;
        public string objectiveDescription;

        
    }
}
