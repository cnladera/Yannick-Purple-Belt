using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spikes Object for controlling the game")]
    public GameObject spikes;
    [Header("Default Hight")]
    public float hight;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", 1f, 14);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(5, Random.Range(-hight, hight), 0);
    }
    
    void InstantiateObjects()
    {
        Instantiate(spikes, transform.position, transform.rotation);
    }
}
