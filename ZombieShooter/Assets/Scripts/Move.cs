using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;

    private float _currentX;

    [SerializeField]
    private Animator _animator;
    private Vector3 dir;  
    // Start is called before the first frame update
    void Start()
    {
        _currentX = transform.position.x;
        dir = Vector3.right + Vector3.up;
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        OnMove();
    }

    private void OnMove()
    {
        float x = Input.GetAxis("Horizontal");
        dir = Vector3.right * x;
        if (x != 0)
        {
            //transform.Rotate(0f, 180f, 0f);
            transform.localScale = new Vector3(Mathf.Sign(x) * Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
        }
        _animator.SetBool("IsMoving", (x != 0));
        transform.Translate(dir * Time.deltaTime * _speed);
    }

}
