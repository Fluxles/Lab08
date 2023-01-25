using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;

    public int rand;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        rand = Random.Range(0, 3);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject[rand], transform.position, transform.rotation);
    }
}
