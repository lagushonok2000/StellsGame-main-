using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] EndGame _endGame;
    [SerializeField] private TMP_Text _levelsText;
    private int _countSeconds;

    public void StartTimer(int seconds)
    {
        _countSeconds = seconds;
        StartCoroutine(LevelsTimer());
    }

    private IEnumerator LevelsTimer()
    {
        for (int i = 0; i < _countSeconds; i--)
        {
            _levelsText.text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
        _endGame.End();
    }
}
