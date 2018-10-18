using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("path");

        //Debug.Log(this.transform.position);


    }



    void OnCollisionEnter(Collision collision)
    {

        //GameObject[] text =  GameObject.FindGameObjectsWithTag("GameOverText");
        //text[0].SetActive(true);
        Debug.Log("COLLISION Path");

    }
}
