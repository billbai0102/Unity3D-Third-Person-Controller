using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPController : MonoBehaviour
{
    public Rigidbody person;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        person = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            person.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            person.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            person.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            person.AddForce(Vector3.right * speed);
        }
    }
}
