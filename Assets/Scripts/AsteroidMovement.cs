using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public float speed = -0.2f;
    public float despawnTime = 5f;

    void Start()
    {
        StartCoroutine(Despawn());
    }

    void Update()
    {
        transform.Translate(0, 0, speed);
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

    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            player.GetComponent<Health>().TakeDamage(2);

            Destroy(gameObject);
        }
    }
}

