using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletMover : MonoBehaviour
{
    public float projectileSpeed;
    public bool active;

    private void OnEnable()
    {
        active = true;
        Invoke("Deactivator", 2f);
    }

    private void OnDisable()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
            transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
    }

    void Deactivator()
    {
        gameObject.SetActive(false);
    }
}
