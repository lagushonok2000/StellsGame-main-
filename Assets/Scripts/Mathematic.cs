using UnityEngine;

public class Mathematic : MonoBehaviour
{
    [SerializeField] private float _sideLength;

    void Start()
    {
        P(_sideLength);
        S(_sideLength);
    }

    private void P(float p)
    {
        p = _sideLength * 4;
        Debug.Log("Периметр: " + p);
    }

    private void S(float s)
    {
        s = _sideLength * _sideLength;
        Debug.Log("Площадь: " + s);
    }
}
