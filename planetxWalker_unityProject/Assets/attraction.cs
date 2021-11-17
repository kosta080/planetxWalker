using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attraction : MonoBehaviour
{
    public GameObject attractedTo;
    public float strengthOfAttraction = 5.0f;
    public float walkSpeed = 10.0f;

    void Start() { }
    void Update()
    {
        Vector3 direction = attractedTo.transform.position - transform.position;
        transform.GetComponent<Rigidbody>().AddForce(strengthOfAttraction * direction);

        transform.Translate(Vector3.forward * (walkSpeed) * Time.deltaTime);
    }
}
