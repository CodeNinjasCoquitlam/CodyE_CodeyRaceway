using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecretLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;

    private void OnCollisionEnter(Collision other)
    {
        if (checkpointTracker.triggerCheckpoints == 5 && other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Secret");
        }
        else
        {
            print("Cheater");
        }
    }
}
