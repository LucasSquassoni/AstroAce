using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletMover : MonoBehaviour
{
    public Vector3 moveDir;
    public float projectileSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDir * projectileSpeed * Time.deltaTime);
    }
}
