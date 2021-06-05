using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AceShooter : MonoBehaviour
{
    public GameObject pelletPrefab;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var bullet = Instantiate(pelletPrefab, firePoint.position, transform.rotation);
            bullet.GetComponent<PelletMover>().moveDir = transform.forward;
        }
    }
}
