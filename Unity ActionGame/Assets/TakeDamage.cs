using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public GameObject damageUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(Collider col)
    {
        var obj = Instantiate<GameObject>(damageUI, col.bounds.center - Camera.main.transform.forward * 2f, Quaternion.identity);
    }
}