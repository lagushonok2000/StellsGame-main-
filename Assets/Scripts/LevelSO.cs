using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelsSO", menuName = "Config/LevelsSO", order = 0)]
public class LevelSO : ScriptableObject
{
    public int[] TimeOnLevel;
    public int[] VictoryPoints;
}
