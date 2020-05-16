using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigPlayerScript : MonoBehaviour
{
    public bool enemyVar;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="enemy")
        {
            enemyVar = true;
        }   
    }
}
