using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField]
    Attacker attackerPrefab = null;

    [SerializeField]
    float minSpawnDelay = 1.0f;

    [SerializeField]
    float maxSpawnDelay = 5.0f;

    bool spawn = true;

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay + 1));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        Instantiate(attackerPrefab.gameObject, transform.position, Quaternion.identity, transform);
    }

    void Update()
    {

    }
}
