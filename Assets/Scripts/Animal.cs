using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//need to be serializable for the save system, so maybe added the attribute just when doing the save system
[System.Serializable]
public abstract class Animal : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10.0f;
    Rigidbody AnimalRb;

    // Start is called before the first frame update
    public virtual void Start()
    {
        Debug.Log("animal");
        AnimalRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Key pressed");
            Jump();
        }

    }

    public virtual void Jump()
    {
        Debug.Log("Jump in Animal class");
        AnimalRb.AddForce(Vector3.up * jumpForce);
    }


}
