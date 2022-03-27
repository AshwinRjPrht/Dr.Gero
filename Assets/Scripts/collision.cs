using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public AudioSource _as;
    public AudioClip collisionSound;



    private void Start()
    {
        _as = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            _as.PlayOneShot(collisionSound);
        }
    }
}
