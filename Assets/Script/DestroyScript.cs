using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    private float sayac;
    void Start()
    {
        
    }

    void Update()
    {
        sayac += Time.deltaTime;
        if(sayac >= 5f)
        {
            Destroy(this.gameObject);
            sayac = 0;
        }
    }
}
