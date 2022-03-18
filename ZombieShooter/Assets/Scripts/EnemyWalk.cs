using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalk : MonoBehaviour
{
    private Vector3 dir;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private Transform _targetPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WalkToTarget();
    }

    public void WalkToTarget()
    {
        dir = new Vector3(_targetPoint.position.x - transform.position.x, transform.position.y, transform.position.z);

        transform.Translate(dir * Time.deltaTime * _speed);
    }
}
