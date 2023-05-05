using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCinteractable : MonoBehaviour
{
    private Animator animator;

    private void Awake(){
        animator = GetComponent<Animator>();
    }


    public void Interact(){
        ChatBubble3D.Create(transform.transform, new Vector3(-.3f, 1.7f, 0f), "Hello there!");

        animator.SetTrigger("Talk");
    }
}
