using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public int Remaining;

    void Update()
    {
        if(Input.GetKeyDown("space") && chosenPowerup && chosenPowerup != powerupList[2])
        {
            Instantiate(chosenPowerup, transform.position, transform.rotation);
            chosenPowerup = null;
        }
        if (Input.GetKeyDown("space") && chosenPowerup == powerupList[2] && Remaining > 0)
        {
            Remaining--;
            Instantiate(chosenPowerup, transform.position, transform.rotation);
        }
        if(Remaining < 1 && chosenPowerup == powerupList[2])
        {
            chosenPowerup = null;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "PowerupBox")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
            if(chosenPowerup == powerupList[2])
            {
                Remaining = 3;
            }
        }
    }
}