using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaSpawner : MonoBehaviour
{
    [SerializeField]
    private int NUM_BALLS;

    [SerializeField]
    private GameObject Bola;

    [SerializeField]
    float x, y, z;

    private float lastSpawn;
    // Start is called before the first frame update
    void Start()
    {
        lastSpawn = Time.time;
    }

    public void Spawn() {
        Debug.Log("Spawning 3 balls");
        if (Time.time - lastSpawn >= 5f) {
            DestroyBolas();
            for (int i = 0; i < NUM_BALLS; i++) {
                Instantiate(Bola, new Vector3(x + i/2f, y, z), Quaternion.identity);
            }
            lastSpawn = Time.time;
        }
    }

    private void DestroyBolas() {
        GameObject[] bolas = GameObject.FindGameObjectsWithTag("bola");
        foreach(GameObject bola in bolas) {
            Destroy(bola);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}