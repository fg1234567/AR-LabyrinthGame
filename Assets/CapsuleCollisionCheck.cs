using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CapsuleCollisionCheck : MonoBehaviour
{

    public Text GameOverText;

    // Use this for initialization
    void Start()
    {
        GameOverText.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameOverText.enabled = false;

        }
        //Debug.Log("capsule");

        //Debug.Log(this.transform.position);

    }

    void OnCollisionEnter(Collision collision)
    {

        GameOverText.enabled = true;
        Debug.Log("COLLISION Capsule");

    }
}
