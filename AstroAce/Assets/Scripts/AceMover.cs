using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AceMover : MonoBehaviour
{
    public float spinSpeed;
    public float thrust;
    public GameObject flame;

    Rigidbody aceRB;

    // Start is called before the first frame update
    void Start()
    {
        aceRB = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(transform.up, (horizontal * spinSpeed) * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            aceRB.AddForce(transform.forward * thrust);
            if (flame.activeSelf == false)
                flame.SetActive(true);
        }
        else
        {
            if (flame.activeSelf == true)
                flame.SetActive(false);
        }
    }
}
