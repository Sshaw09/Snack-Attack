using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float timer = 3;
    public int pointValue;
    //public ParticleSystem explosionParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameManager.score += pointValue;
            //Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);

        }

        if (other.gameObject.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}
