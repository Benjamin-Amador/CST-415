using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrediction : MonoBehaviour
{
    //public GameObject player;
    public float distance;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w") && Input.GetKey("d"))
        {
            transform.localPosition = new Vector3(distance * (Mathf.Sqrt(2) / 2), 0f, distance * (Mathf.Sqrt(2) / 2));
        }
        else if (Input.GetKey("w") && Input.GetKey("a"))
        {
            transform.localPosition = new Vector3(distance * -(Mathf.Sqrt(2) / 2), 0f, distance * (Mathf.Sqrt(2) / 2));
        }
        else if (Input.GetKey("s") && Input.GetKey("a"))
        {
            transform.localPosition = new Vector3(distance * -(Mathf.Sqrt(2) / 2), 0f, distance * -(Mathf.Sqrt(2) / 2));
        }
        else if (Input.GetKey("s") && Input.GetKey("d"))
        {
            transform.localPosition = new Vector3(distance * (Mathf.Sqrt(2) / 2), 0f, distance * -(Mathf.Sqrt(2) / 2));
        }
        else if (Input.GetKey("w"))
        {
            transform.localPosition = new Vector3(0f, 0f, distance);
        }
        else if (Input.GetKey("s"))
        {
            transform.localPosition = new Vector3(0f, 0f, -distance);
        }
        else if (Input.GetKey("d"))
        {
            transform.localPosition = new Vector3(distance, 0f, 0f);
        }
        else if (Input.GetKey("a"))
        {
            transform.localPosition = new Vector3(-distance, 0f, 0f);
        }
    }
}

