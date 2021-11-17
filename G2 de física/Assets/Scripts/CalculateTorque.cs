using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateTorque : MonoBehaviour
{
    [SerializeField] private List<Plate> plates;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        foreach(Plate plate in plates)
        {
            float plateTorque = plate.distance * plate.weight;
            if(plate.isLeft)
            {
                rb.AddTorque(plateTorque);
            }
            else
            {
                rb.AddTorque(plateTorque * -1);
            }
        }
    }
}
