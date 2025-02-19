using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCollider : MonoBehaviour
{
    public CodeyMove movement;

    public GameObject Codey;

    void Start()
    {
        movement = Codey.GetComponent<CodeyMove>();
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            movement.Speed = 350;
            Invoke("SetSpeedNormal", 5);
        }
    }

    void SetSpeedNormal()
    {
        movement.Speed = 300;
    }
}
