using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;

    private GameObject _bulletGameObject;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private Transform _bulletSpawnPoint;

    [SerializeField]
    private Transform _playerTransform;

    [SerializeField]
    private AudioSource _audioSource;

    [SerializeField]
    private AudioManager _audioManager;

    //[SerializeField]
    //ParticleSystem

    private bool rifleUp;

    // Start is called before the first frame update
    void Start()
    {
        rifleUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rifleUp = true;
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            rifleUp = false;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && rifleUp == true)
        {
            Shoot();
        }
       
    }


    private void Shoot()
    {
        _bulletGameObject = Instantiate(_bulletPrefab, _bulletSpawnPoint.position, Quaternion.identity);
        _bulletGameObject.GetComponent<Bullet>().Launch(Mathf.Sign(_playerTransform.localScale.x) * _bulletSpawnPoint.right, _speed);
        _audioManager.Play("Shot");
        //ParticleSystem.Play();
    }
}
