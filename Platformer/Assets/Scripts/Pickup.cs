using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;

    [SerializeField] int coinValue = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().ProcessPlayerScore(coinValue);

        //play clip at point uses vector 3 information for where the sound plays from
        AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);


        Destroy(gameObject);
    }
}
