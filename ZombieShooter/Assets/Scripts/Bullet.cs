using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb;

    [SerializeField]
    private float _lifetime = 2f;

    [SerializeField]
    private int _damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Launch(Vector3 dir, float _speed)
    {
        _rb.velocity = dir * _speed;
        transform.localScale = new Vector3(Mathf.Sign(dir.x) * transform.localScale.x, transform.localScale.y, transform.localScale.z);
        Destroy(gameObject, _lifetime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("AAARHRHHGHGH!!");
            collision.GetComponent<EnemyHealth>().TakeDamage(_damage);
            Destroy(gameObject);
        }

        else if (collision.gameObject.CompareTag("Boss"))
        {
            //Debug.Log("AAARHRHHGHGH!!");
            collision.GetComponent<EnemyHealth>().TakeDamage(_damage);
            Destroy(gameObject);
        }
    }


}
