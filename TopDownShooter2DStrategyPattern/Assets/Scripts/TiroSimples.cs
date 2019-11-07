using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroSimples : Arma, IArma
{
   [SerializeField] float speed;
    Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        firePoint = GetComponentInChildren<Transform>().GetChild(0);
    }
    public void Atirar()
    {
       
    }

   
}
