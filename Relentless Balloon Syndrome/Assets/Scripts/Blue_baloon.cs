using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Blue_baloon : MonoBehaviour
{
    public Animator animator;
    static AudioSource Audio;
    public AudioClip au;
    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }
    void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            destroy_baloon();
        }
    }
    public void destroy_baloon()
    {
        Globals.Change_Points(10);
        Globals.Change_HP(10);
        Audio.PlayOneShot(au);
        animator.SetBool("Clicked", true);
    }
}
