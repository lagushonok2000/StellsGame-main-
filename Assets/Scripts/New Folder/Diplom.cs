using UnityEngine;

public class Diplom : MonoBehaviour
{
    [SerializeField] private int[] _intArray;

    void Start()
    {
        if (_intArray.Length < 2)
        {
            Debug.Log("¬ведите хот€ бы 2 значени€ в массив");
            return;
        }

        Debug.Log(IncreasingNumbers());
    }

    private bool IncreasingNumbers()
    {
        int a = _intArray[0];

        for (int i = 1; i < _intArray.Length; i++)
        {
            if (_intArray[i] > a)
            {
                a = _intArray[i];
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
