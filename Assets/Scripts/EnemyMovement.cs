using TMPro;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField,Range(0, 100)] private int _enemySpeed;
    [SerializeField, Range(0, 100)] private float _enemyRotationSpeed;
    [SerializeField] private Transform[] _wayPoints;

    private Vector3 direction;
    private int currentWayPointsIndex;

    private void Update()
    {
        WayMovement();
        Rotation();
    }

    private void WayMovement()
    {
        Vector3 targetPosition = _wayPoints[currentWayPointsIndex].position;
        direction = targetPosition - _enemyPrefab.transform.position;

        _enemyPrefab.transform.position += direction.normalized * _enemySpeed * Time.deltaTime;

        if (Vector3.Distance(_enemyPrefab.transform.position, targetPosition) < 0.1f)
        {
                currentWayPointsIndex++;
        }

        if (currentWayPointsIndex == _wayPoints.Length)
        {
            currentWayPointsIndex = 0;
        }
    }

    private void Rotation()
    {
        Vector3 previousPosition;
        
        if (direction.magnitude > 0.01f)
        {

            direction.Normalize();

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            Quaternion targetRotation = Quaternion.Euler(0, 0, angle);

            _enemyPrefab.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, _enemyRotationSpeed * Time.deltaTime);
        };

            
            previousPosition = transform.position;
        }
    }

