using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class Manager : MonoBehaviour {


    public TextMesh geriSayim ;


    private bool isTrackableFound; 

    private float countDown = 5;
    private bool isCountDownStarted = false;

    // Use this for initialization
    void Start () {




    }

    void startGame()
    {

    }

    // Update is called once per frame
    void Update () {

        isTrackableFound = FindObjectOfType<DefaultTrackableEventHandler>().isTrackableFound;

        if (isTrackableFound && !isCountDownStarted )
        {
            isCountDownStarted = true;

        } else if (isTrackableFound)
        {   
            if( (int)countDown == 0)
            {
                geriSayim.text = "0";
                startGame();
            }
            else
            {
                geriSayim.text = ((int)countDown).ToString();
                countDown -= Time.deltaTime;

            }
        }
	}










}
