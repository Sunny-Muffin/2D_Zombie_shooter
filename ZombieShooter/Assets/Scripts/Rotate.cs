using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float angle = 0f;
    public float _rotationSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle = 1 * Time.deltaTime * _rotationSpeed;
        transform.Rotate(0, 0, angle, Space.World);
    }
}
