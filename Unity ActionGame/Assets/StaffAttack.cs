using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffAttack : MonoBehaviour
{
    private GameObject damageUI;
    private AudioSource sound01;
    // Start is called before the first frame update
    void Start()
    {
        sound01 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Enemy")
        {
            col.transform.GetComponent<TakeDamage>().Damage(col);
            sound01.PlayOneShot(sound01.clip);
        }
        if(col.tag == "Object")
        {
            sound01.PlayOneShot(sound01.clip);
        }
    }
}
