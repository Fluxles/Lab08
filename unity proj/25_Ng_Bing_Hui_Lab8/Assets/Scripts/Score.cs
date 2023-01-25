using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int ScoreTracker = 0;
    public Text Scoretxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Scoretxt.text = "Score:" + (ScoreTracker = ScoreTracker + 10);
        }
    }

}
