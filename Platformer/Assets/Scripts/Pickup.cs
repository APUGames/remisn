using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //play clip at pint uses vector 3 information for where the sound plays from
        AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);


        Destroy(gameObject);
    }
}
