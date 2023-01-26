using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPoint : MonoBehaviour
{
    [SerializeField]
    private AudioSource _winAudio;
    private AudioClip _audioData;
    void Start()
    {
        // _audioData = GetComponent<AudioSource>();
        _winAudio.enabled=false;
      
    }//Start

    
    void Update()
    {
        
    }//Update\
    private void OnCollisionEnter(Collision collision)
    {
        _winAudio.enabled = true;
        if (collision.gameObject.CompareTag("Barrel")) _winAudio.Play(0);//Coding Challange 015
    }//On Collision Enter
}//Class
