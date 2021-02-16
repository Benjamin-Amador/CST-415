using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Score.scoreValue += 10;

            Destroy(gameObject);
            //gameObject.SetActive(false);
        }
    }
}
