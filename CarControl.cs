using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    [SerializeField]
    private float _carSpeed = 10f;
    [SerializeField]
    private float _carTurnSpeed = 2f;
    [SerializeField]
    private GameObject _breakLight;
    [SerializeField]
    private GameObject _barrel;
    [SerializeField]
    private GameObject _barrelTriggerPoint;
    void Start()
    {
        
    }//Start

    
    void Update()
    {
        CarMovements();
    }//Update
    private void CarMovements()
    {
       transform.Translate(new Vector3(Input.GetAxis("Vertical") * Time.deltaTime * _carSpeed,0f,0f));
       transform.Rotate(0, Input.GetAxis("Horizontal")*_carTurnSpeed*Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.Space)) _breakLight.SetActive(true);
        if (Input.GetKeyUp(KeyCode.Space)) _breakLight.SetActive(false);  
    }//Car Movements
    
    /*private void OnCollisionStay(Collision collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("BarrelTrigger"))
        {
            Instantiate(_barrel, _barrelTriggerPoint.transform.position, Quaternion.identity);
            print("Collision Occured");
        }
    }*/
}//Class
