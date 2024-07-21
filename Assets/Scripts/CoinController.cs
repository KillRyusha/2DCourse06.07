using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public GameData GameData;
    [SerializeField] private TMPro.TMP_Text coinsText;
    [SerializeField] private int value = 1;
    [SerializeField] private AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameData.Coins += value;
            coinsText.text = "Coins: " + GameData.Coins;
            audioSource.Play();
            Destroy(gameObject);
        }
    }
}
