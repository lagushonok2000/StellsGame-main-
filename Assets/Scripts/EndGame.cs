using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject _defeatPanel;
    [SerializeField] private PlayerMovement _playerMov;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        End();
    }

    public void End()
    {
        _defeatPanel.SetActive(true);
        _playerMov.enabled = false;
    }
}
