using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("Points_over_Time", 1.0f, 1.0f);
    }

    void Update()
    {
        gameObject.GetComponent<Text>().text = "Score: " + Globals.points.ToString(); // Show points

        //Balloons speed depending on points
        float change = (Globals.points / Globals.speed_up);
        Globals.min_balloon_speed = Globals.start_min_balloon_speed +  (change / 5);
        Globals.max_balloon_speed = Globals.start_max_balloon_speed + (change / 5);
    }
    void Points_over_Time()
    {
        Globals.points += Globals.points_over_time;// Add points for time in game
    }

    public void Turn_off()
    {
        CancelInvoke();
    }
}
