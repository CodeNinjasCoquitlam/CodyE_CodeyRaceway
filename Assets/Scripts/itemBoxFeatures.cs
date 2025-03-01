using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Rotate the object around the Y axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);

            Invoke("itemBoxRespawn", 2.0f);
        }

    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}
