using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMedium : MonoBehaviour
{
    public string collisionTag;
    
    void OnCollisionEnter(Collision collision)
    {        
        print("Collided with Something.");
        
        if (collision.gameObject.CompareTag(collisionTag))
        {
                print("Wow, That's Correct!!!");
        }
    }
}
