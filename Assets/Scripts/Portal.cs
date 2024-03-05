using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private string player = "Player";
    [SerializeField] private string nextLavelName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer(player))
        {
            SceneManager.LoadScene(nextLavelName);
        }
    }
}
