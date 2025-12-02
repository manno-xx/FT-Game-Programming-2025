using System;
using UnityEngine;

public class TriggerResponse : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // if the collision was with the gameobject with the tag "Player", disappear
        if(other.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
