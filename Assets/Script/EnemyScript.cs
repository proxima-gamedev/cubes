using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
     public GameObject objectToFollow;
    public float speed = 2.0f;
    public Rigidbody rb;
    public float hiz =10;
    public PlayerScript playerScr;
    public float hizFree;
    public TrigPlayerScript trigOyuncu;
    private Vector3 yon = Vector3.right;
    private bool duvarVar=false;

    void Start()
    {
        
    }

    
    void Update()
    {   
      if(objectToFollow.gameObject!=null)
      {

        if(trigOyuncu.enemyVar==true)
        {
          float interpolation = speed * Time.deltaTime;
        
          Vector3 position = this.transform.position;
        // position.y = Mathf.Lerp(this.transform.position.y , objectToFollow.transform.position.y , interpolation);
          position.x = Mathf.Lerp(this.transform.position.x , objectToFollow.transform.position.x, interpolation );
          position.z = Mathf.Lerp(this.transform.position.z , objectToFollow.transform.position.z, interpolation );
        
          this.transform.position = position;
         
        }
        
        if(trigOyuncu.enemyVar==false)
        {
          rb.AddForce(yon*Time.deltaTime*hizFree);
        }
        
      }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag =="Player") 
        {   
           
          playerScr.health -= 20;
        }
        if(other.gameObject.tag=="wall")
        {
          yon*= -1f;
        }
    }
  
}
