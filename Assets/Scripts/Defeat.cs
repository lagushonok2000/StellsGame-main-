using UnityEngine;

public class Defeat : MonoBehaviour
{
    [SerializeField] private GameObject _defeatPanel;
    [SerializeField] private PlayerMovement _playerMov;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            _defeatPanel.SetActive(true);
            _playerMov.enabled = false;
        } 
    }
}
