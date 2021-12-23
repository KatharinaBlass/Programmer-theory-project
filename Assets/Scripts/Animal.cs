using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//need to be serializable for the save system, so maybe added the attribute just when doing the save system
[System.Serializable]
public abstract class Animal : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10.0f;
    Rigidbody AnimalRb;
    protected Animator animator;
    private string _Name = "Animal";
    public string AnimalName
    {
        get { return _Name; }
        set
        {
            if (value.Length <= 0)
            {
                Debug.LogError("You cannot set an empty string!");
            }
            else
            {
                _Name = value;
            }
        }
    }
    // Start is called before the first frame update
    public virtual void Start()
    {
        AnimalRb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            PresentSelf();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Relax();
        }

    }

    public virtual void Jump()
    {
        AnimalRb.AddForce(Vector3.up * jumpForce);
    }

    public virtual void PresentSelf()
    {
        Debug.Log("Hello! My Name is " + _Name);
    }

    public virtual void Relax()
    {
        // Do nothing
    }
}
