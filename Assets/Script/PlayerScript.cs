using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float hiz;
    public GameObject particleInstantinePoint;
    public ParticleSystem zaferPartical;
    float sayac;
    public GameObject winSes;
    public GameObject hurtSes;
    public GameObject namlu;
    public GameObject mermi;

    public float health = 100;
    public GameObject loserSes;
    public float mermiHiz = 100;
    void Start()
    {

    }


    void Update()
    {
        sayac += Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontal, 0, vertical) * hiz * Time.deltaTime;

        if (health <= 0) Bozgun();
        if (sayac >= 1)
        {
            GameObject klonMermi = Instantiate(mermi, namlu.transform.position, namlu.transform.rotation);
            Rigidbody mermiRb = klonMermi.GetComponent<Rigidbody>();
            //namlunun baktigi yone dogru hiz ayarladik
            mermiRb.velocity = namlu.transform.forward * Time.deltaTime * mermiHiz;
            sayac = 0f;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Finish")
        {
            Zafer();
        }
        if (other.gameObject.tag == "enemy")
        {
            Instantiate(hurtSes, particleInstantinePoint.transform.position, particleInstantinePoint.transform.rotation);
        }


    }
    public void Zafer()
    {
        Instantiate(zaferPartical, particleInstantinePoint.transform.position, particleInstantinePoint.transform.rotation);
        Instantiate(winSes, particleInstantinePoint.transform.position, particleInstantinePoint.transform.rotation);
    }
    public void Bozgun()
    {
        Destroy(this.gameObject);
        Instantiate(loserSes, particleInstantinePoint.transform.position, particleInstantinePoint.transform.rotation);
    }

}
