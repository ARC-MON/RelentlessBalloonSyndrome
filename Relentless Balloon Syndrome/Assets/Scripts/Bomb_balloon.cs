using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bomb_balloon : MonoBehaviour
{
    public Animator animator;
    void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            var Colider = Physics2D.OverlapCircleAll(transform.position, 2);
            foreach (var item in Colider)
            {
                var b = item.GetComponent<Blue_baloon>();
                if(b)
                {
                    b.destroy_baloon();
                } 
            }
            destroy_baloon();
        }
    }
    public void destroy_baloon()
    {
        Globals.Change_Points(10);
        Globals.Change_HP(10);
        animator.SetBool("Clicked", true);
    }
}
