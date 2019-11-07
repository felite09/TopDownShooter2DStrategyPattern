﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        Invoke("Die", Mathf.CeilToInt(anim.GetCurrentAnimatorStateInfo(0).length));
    }

    

    // Update is called once per frame
    void Die()
    {

        Destroy(gameObject);
    }
}
