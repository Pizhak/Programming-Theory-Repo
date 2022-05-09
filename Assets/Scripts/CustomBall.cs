using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBall : Ball  // INHERITANCE
{
    [SerializeField] private int size;
    [SerializeField] private int mass;
    [SerializeField] private string ballName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            name = ballName;   // ENCAPSULATION

            // ABSTRACTION
            SetMass();
            SetSize();
            Move();
            DisplayText();
        }
    }

    public override void SetSize() // POLYMORPHISM
    {
        transform.localScale = new Vector3(size, size, size);        
    }

    public override void SetMass() // POLYMORPHISM
    {
        gameObject.GetComponent<Rigidbody>().mass = mass;       
    }

}
