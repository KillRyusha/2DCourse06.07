using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestarter : MonoBehaviour
{
    public int Level;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(Level);
    }
}
