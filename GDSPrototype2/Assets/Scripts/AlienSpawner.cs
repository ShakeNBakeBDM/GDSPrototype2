using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienSpawner : MonoBehaviour
{
    public float timerspeed = 2f;
    private float elapsed;

    public GameObject alienPrefab;
    GameObject alienPrefabClone;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= timerspeed)
        {
            elapsed = 0f;
            alienPrefabClone = Instantiate(alienPrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy(alienPrefabClone, 3);
        }
    }
}
