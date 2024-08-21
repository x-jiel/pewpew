using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int HP;
    public bool takeDamage;
    // Start is called before the first frame update
    void Update()
    { 
        if (takeDamage == true)
        { HP -= 1;
        }
    }
}