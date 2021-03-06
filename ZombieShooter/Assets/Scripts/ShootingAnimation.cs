using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _animator.SetBool("IsShooting", true);
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            _animator.SetBool("IsShooting", false);
        }
        
    }
}
