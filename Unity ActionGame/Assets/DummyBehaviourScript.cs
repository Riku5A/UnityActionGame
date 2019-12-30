using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBehaviourScript : MonoBehaviour
{
    private Animator animator;
    private GameObject damageUI;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Weapon")
        {
            animator.SetBool("Hit", true);
        }
    } 

    void PlayStep()
    {

    }

    void Grunt()
    {

    }
}
