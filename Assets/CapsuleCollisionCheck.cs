using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CapsuleCollisionCheck : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("capsule");

        //Debug.Log(this.transform.position);

    }

    void OnCollisionEnter(Collision collision)
    {

        //GameObject[] text =  GameObject.FindGameObjectsWithTag("GameOverText");
        //text[0].SetActive(true);
        Debug.Log("COLLISION Capsule");

    }
}
