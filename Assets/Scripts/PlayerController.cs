using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody _rigidbody;
    public float jumpForce = 10f;
    private bool isOnTheGround = true;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround)
        {
            isOnTheGround = false;
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        isOnTheGround = true;
    }
}
