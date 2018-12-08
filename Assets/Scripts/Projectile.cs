using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField]
    float moveSpeed = 1.0f;

    [SerializeField]
    float rotateSpeed = 1.0f;

    [SerializeField]
    int damage = 1;


    void Update () {
        Move();
        //Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(-Vector3.forward, rotateSpeed * Time.deltaTime);
    }

    private void Move()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        var attacker = otherCollider.GetComponent<Attacker>();

        if(attacker != null && health != null)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
