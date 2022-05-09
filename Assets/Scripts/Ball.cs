using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;  

    private string m_Name = "Ball";
    public string name  // ENCAPSULATION
    {
        get { return m_Name; }
        set
        {
            if (value.Length < 8)
            { m_Name = value; }
            else 
            { Debug.LogError("Name too big!"); }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DisplayText();  // ABSTRACTION

    }

    protected void Move()   // ABSTRACTION
    {
        gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 100, ForceMode.Impulse);
    }

    public virtual void SetSize() // POLYMORPHISM
    {
        transform.localScale = new Vector3(1, 1, 1);
    }

    public virtual void SetMass() // POLYMORPHISM
    {
        gameObject.GetComponent<Rigidbody>().mass = 1;
    }

    protected void DisplayText()   // ABSTRACTION
    {
        nameText.SetText(m_Name);
    }
}
