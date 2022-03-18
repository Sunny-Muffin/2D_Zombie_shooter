using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private Rigidbody2D _rb;

    [SerializeField]
    private bool _isGrounded;

    [SerializeField]
    private Transform _GroundChecker;

    [SerializeField]
    private LayerMask _groundLayer;

    [SerializeField]
    private float _jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        OnJump();
    }

    private void OnJump()
    {
        _isGrounded = Physics2D.Raycast(_GroundChecker.position, Vector2.down, 2f, _groundLayer);

        if (_isGrounded && Input.GetKey(KeyCode.Space))
        {
            _rb.velocity = new Vector2(0, _jumpForce);
            //Debug.Log("SPACE!!!");
        }

        if (_isGrounded)
        {
            //Debug.Log("grounded");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(_GroundChecker.position, _GroundChecker.position + 2f * Vector3.down);
    }
}
