using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawn : MonoBehaviour
{
    public float timerspeed = 2f;
    private float destroyT = 2.7f;
    private float elapsed;

    public GameObject meteorPrefab;
    GameObject meteorPrefabClone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        elapsed += Time.deltaTime;
        if(elapsed >= timerspeed)
        {
            elapsed = 0f;
        meteorPrefabClone = Instantiate(meteorPrefab, transform.position, Quaternion.identity) as GameObject;
        Destroy(meteorPrefabClone, destroyT);
        }
    }
}
