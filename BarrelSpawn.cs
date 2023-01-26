using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject _barrel;
    [SerializeField]
    private GameObject _barrelSpawnPoint;
    
    void Start()
    {
        
    }//Start

   
    void Update()
    {
        
    }//Update
    private void OnCollisionEnter(Collision collision)
    {
       
    }//On Collision Enter
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            Instantiate(_barrel, _barrelSpawnPoint.transform.position, Quaternion.identity);
            print("Collision Occured");
        }
    }
}//Class
