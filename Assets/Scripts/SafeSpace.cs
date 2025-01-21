using TMPro;
using UnityEngine;

public class SafeSpace : MonoBehaviour
{
    [SerializeField] private PlayerInviseCounter _counterClass;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            _counterClass.Counter(1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            _counterClass.Counter(-1);
        }
    }

   
}