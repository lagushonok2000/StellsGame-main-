using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _player;
    [SerializeField,Range(0,100)] private float _speed;

    private Vector2 _movement;

    private void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        _movement = new Vector2(hInput, vInput);
    }
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        _player.velocity = _movement * _speed;
       // _player.transform.Translate(_movement * _speed * Time.deltaTime);
    }

}
