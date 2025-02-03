using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Red_baloon : MonoBehaviour
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
            Globals.Change_HP(-10);
            Audio.PlayOneShot(au);
            animator.SetBool("Clicked", true);
        }
    }
}
