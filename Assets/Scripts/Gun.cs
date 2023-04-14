using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Gun : MonoBehaviour
{
    private StarterAssetsInputs _inputs;
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject bulletPoint;
    [SerializeField]
    private float bulletSpeed = 40;
    


    // Start is called before the first frame update
    void Start()
    {
        _inputs = transform.root.GetComponent<StarterAssetsInputs>();

    }

    // Update is called once per frame
    void Update()
    {
        if(_inputs.shoot)
            {
                Shoot();
                _inputs.shoot = false;
            }
    }

        void Shoot()
        {

       
            GameObject bullet = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation);
          
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
            Destroy(bullet, 1);
        
        
    }
}
