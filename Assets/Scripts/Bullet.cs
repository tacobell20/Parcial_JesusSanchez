using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 0.2f;
    public float despawnTime = 3f;

    void Start()
    {
        transform.SetParent(null);
        StartCoroutine(Despawn());
    }

    void Update()
    {
        transform.Translate(0, speed, 0);
    }

    IEnumerator Despawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(DespawnTime());

            Destroy(gameObject);

        }
    }

    private float DespawnTime()
    {
        return despawnTime;
    }

    private void OnTriggerEnter(Collider Asteroid)
    {
        if (Asteroid.CompareTag("Asteroid"))
        {
            Asteroid.GetComponent<Health>().TakeDamage(1);

        }
    }

}
