using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxCollider : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0f, 10f * Time.deltaTime, 0f, Space.Self);
    }
   void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Invoke("Reappear", 5);
        }
    }
    void Reappear()
    {
        gameObject.SetActive(true);
    }
}
