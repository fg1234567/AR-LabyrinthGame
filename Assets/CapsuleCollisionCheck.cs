using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CapsuleCollisionCheck : MonoBehaviour
{

    public Text GameOverText;
    public Text UberText;
    public Text NescafeText;
    public Text TebriklerText;

    private int coinCount = 0;

    // Use this for initialization
    void Start()
    {
        GameOverText.enabled = false;
        UberText.enabled = false;
        NescafeText.enabled = false;
        TebriklerText.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameOverText.enabled = false;
            UberText.enabled = false;
            NescafeText.enabled = false;
            TebriklerText.enabled = false;

        }
        //Debug.Log("capsule");

        //Debug.Log(this.transform.position);

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);

        if (collision.gameObject.name == "LogoStandUber")
        {
            UberText.enabled = true;
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.name == "LogoStandNescafe")
        {
            NescafeText.enabled = true;
            collision.gameObject.SetActive(false);

        }
        else if (collision.gameObject.transform.parent.name == "Coins")
        {
            collision.gameObject.SetActive(false);
            coinCount++;

        }
        else if (collision.gameObject.name == "finishText" && coinCount == 6)
        {
            TebriklerText.enabled = true;
            
        }
        else if (collision.gameObject.name == "path")
        {
            GameOverText.enabled = true;

        }

        Debug.Log("COLLISION Capsule");

    }
}
