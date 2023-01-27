using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingVideo : MonoBehaviour
{
    public float timeToRun;
    private float countDownTimer;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer = timeToRun;
    }

    // Update is called once per frame
    void Update()
    {
        if ( countDownTimer > 0 )
        {
            countDownTimer -= Time.deltaTime;
        }
        else 
        {
            // Destroy( gameObject );
            gameObject.SetActive( false );
        }
    }
}
