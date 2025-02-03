using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Globals
{
    //Starting Variables
    public static float start_min_balloon_speed = 1; // Starting minimal ballon speed
    public static float start_max_balloon_speed = 3; // Starting max baloon speed
    public static int start_red_b_chance = 25; // Starting chance to spawn red baloon insted of blue
    public static int start_bomb_b_chance = 5; // Starting chance to spawn red baloon insted of blue

    //Options Variables
    public static float hp_max = 100; // Max possible HP
    public static int speed_up = 1000; // How much new points must reach to speed up game
    public static int points_over_time = 1; // How much points per tick
    public static int balloon_number = 2; // Baloons generated at the time
    public static float ballon_time_Generation = 1.0f; // Time Between baloon generation


    //Changing Variables
    public static int red_b_chance = start_red_b_chance; // Chance to spawn red baloon insted of blue
    public static int bomb_b_chance = start_bomb_b_chance; // Chance to spawn red baloon insted of blue
    public static float min_balloon_speed = start_min_balloon_speed; // Minimal ballon speed
    public static float max_balloon_speed = start_max_balloon_speed; // Max baloon speed
    public static float hp = hp_max; // Player actual HP
    public static int points = 0; // Player actual points

    //Change HP
    public static void Change_HP(int HP)
    {
        hp += HP;
        if (hp > hp_max)
        {
            hp = hp_max;
        }
    }

    //Change Points
    public static void Change_Points(int Points)
    {
        points += Points;
        if (points < 0)
        {
            points = 0;
        }
    }
    public static void Restart()
    {
        red_b_chance = start_red_b_chance;
        min_balloon_speed = start_min_balloon_speed;
        max_balloon_speed = start_max_balloon_speed;
        hp = hp_max;
        points = 0;
    }
}
