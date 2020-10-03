using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineScript : MonoBehaviour
{
    public int id;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (id == 4)
            {
                Debug.Log("You lose!");
                SceneManager.LoadScene("MainMenu");
            }
            if (id == 1)
            {
                Debug.Log("Finish first map!");
                SceneManager.LoadScene("Stage2");
            }
            Debug.Log("Finish!");
            if (id == 2)
            {
                Debug.Log("Change Map!");
                SceneManager.LoadScene("Credit");
            }
        }
    }
}
