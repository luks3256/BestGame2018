using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour {

    public GameObject ObjectToDestroy;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag== "Player")
        {
            Debug.Log("hit");
            Destroy(gameObject);
        }
    }
}
