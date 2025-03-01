using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public bool powerUpChosen = false;
    public int modifyZPosition;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "PowerupBox")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
            powerUpChosen = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && powerUpChosen == true)
        {
            GameObject Powerup = Instantiate(chosenPowerup, transform.position + transform.forward * 3, transform.rotation);
            chosenPowerup = null;
            powerUpChosen = false;

        }
    }
}
