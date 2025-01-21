using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelsChanger : MonoBehaviour
{
    [SerializeField] private LevelSO _levelSO;
    [SerializeField] private Timer _timer;
    [SerializeField] private Transform[] _levelsGates;
    [SerializeField] private Transform[] _levelsStartPositions;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] public TMP_Text _levelsText;

    void Update()
    {
        if (_playerTransform.position == _levelsGates[Level.Current].position)
        {
            ChangeLevels();
        }
    }
    private void StartLevel()
    {
        _playerTransform.position = _levelsGates[Level.Current].position;
        _timer.StartTimer(_levelSO.TimeOnLevel[Level.Current]);
    }

    private void ChangeLevels()
    {
        Level.Current++;
        _playerTransform.position = _levelsStartPositions[Level.Current].position;
    }

    
}
