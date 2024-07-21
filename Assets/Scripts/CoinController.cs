using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private int coins;
    [SerializeField] private TMPro.TMP_Text coinsText;
    [SerializeField] private int value = 1;
    [SerializeField] private AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            coins += value;
            coinsText.text = "Coins: " + coins;
            audioSource.Play();
            Destroy(gameObject);
        }
    }
}
