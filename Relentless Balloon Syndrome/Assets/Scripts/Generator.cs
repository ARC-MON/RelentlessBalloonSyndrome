using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public float speed = 1f;
    public float diviation = 0f;
    public float baloon_chance;
    public List<Rigidbody2D> balloon;
    public bool go_on;

    //Generating balloons with start of the game
    void Start()
    {
        go_on = true;
        StartCoroutine("Generate");
    }

    //What kind of balloon will spawn
    IEnumerator Generate()
    {
        while (go_on)
        {
            for (int i = 0; i < Globals.balloon_number; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    baloon_chance = Random.Range(1, 101);

                    if (baloon_chance <= Globals.bomb_b_chance)
                    {
                        float change = (Globals.points / Globals.speed_up);

                        if (0.25f + (change) / 8 > 0.75)
                            Generate_balloon(balloon[2], j, 0.75f, 0.45f, 0.5f);
                        else
                            Generate_balloon(balloon[2], j, 0.25f + (change / 8), 0.45f, 1f - (change / 8));
                    }
                    else if (baloon_chance <= Globals.red_b_chance + Globals.bomb_b_chance && baloon_chance > Globals.bomb_b_chance)
                    {
                        Generate_balloon(balloon[1], j,1f,0.45f,0.25f);
                    }
                    else
                    {
                        float change = (Globals.points / Globals.speed_up);

                        if (0.25f + (change) / 8 > 0.75)
                            Generate_balloon(balloon[0], j, 0.75f, 0.45f, 0.5f);
                        else
                            Generate_balloon(balloon[0], j, 0.25f + (change / 8), 0.45f, 1f - (change / 8));
                    }
                }
            }
            if ((Globals.ballon_time_Generation - (float)(Globals.points / (Globals.speed_up)) / 5) < 0.5)
                yield return new WaitForSeconds(0.5f);
            else
                yield return new WaitForSeconds(Globals.ballon_time_Generation - (float)(Globals.points / (Globals.speed_up)) / 5);
        }
    }

    //Generating Balloon
    void Generate_balloon(Rigidbody2D balloon, int i,float r,float g,float b)
    {
            speed = Random.Range(Globals.min_balloon_speed, Globals.max_balloon_speed+1);
            diviation = Random.Range(-1f, 1f);

            Rigidbody2D instance = Instantiate(balloon, transform);
            SpriteRenderer s = instance.GetComponent<SpriteRenderer>();
            if (i == 1)
            {
                instance.gameObject.layer = 7;;
                s.color = new Color(r-0.1f,g-0.1f,b-0.1f);
                s.sortingOrder = 2;
            }
            else
                s.color = new Color(r,g,b);

            instance.velocity = Vector2.up * speed;
            instance.transform.position = instance.transform.position + Vector3.right * diviation;
        }
    }
