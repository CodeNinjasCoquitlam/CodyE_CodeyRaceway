using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliSpeed : MonoBehaviour
{
    private float startingXPos;
    private float xSpeed;
    private float startingZPos;
    private float zSpeed;
    private int rotation;
    // Start is called before the first frame update
    void Start() {
        startingXPos = transform.position.x;
        xSpeed = startingXPos;
        startingZPos = transform.position.z;
        zSpeed = startingZPos;
    }

    // Update is called once per frame
    void Update() {
        
        if (transform.position.z < 127) {
            rotation = 1;
            
        } else if (transform.position.z > startingZPos) {
            rotation = -1;
           
        }
        if (rotation == 1) {
            zSpeed++;
            xSpeed += 0.01f;
        } else {
            zSpeed--;
            xSpeed += -0.01f;
        }
        transform.position = new Vector3(xSpeed, transform.position.y, zSpeed);
    }
}
