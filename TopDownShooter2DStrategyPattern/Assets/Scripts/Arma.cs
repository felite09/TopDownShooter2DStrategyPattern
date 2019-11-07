using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] protected sbyte dano;
    public sbyte getDano()
    {
        return dano;
    }
}
