using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField]
    int startingHealth = 10;

    int currentHealth = 10;


    [SerializeField]
    GameObject deathFx;

    // Use this for initialization
    void Start () {
        currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DealDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            TriggerDeathFx();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathFx()
    {
        if (deathFx != null)
        {
            var fx = Instantiate(deathFx, transform.position, transform.rotation);
            var ps = fx.GetComponent<ParticleSystem>();
            
            Destroy(fx, ps.main.duration + 1);
        }
    }
}
