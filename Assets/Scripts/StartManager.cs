using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public bool start = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            start = true;
            GetComponent<SpeedManager>().speed = 1;
            GameObject.Find("StartGroup").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("ScoreGroup").GetComponent<CanvasGroup>().alpha = 1;
        }
    }
}
