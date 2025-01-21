using TMPro;
using UnityEngine;

public class PlayerInviseCounter : MonoBehaviour
{
    private int _sphereCount;
    [SerializeField] private TMP_Text _text;

    public void Counter(int add)
    {
        _sphereCount += add;
        Debug.Log(_sphereCount);

        if (_sphereCount == 4)
        {
            _text.text = "Ты в безопасности";
        }
        else
        {
            _text.text = "";
        }
    }
}
