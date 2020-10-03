using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public void StageSelectionButtonClick(Button button)
    {
        SceneManager.LoadScene("StageSelection");
    }

    public void CreditButtonClick(Button button)
    {
        SceneManager.LoadScene("Credit");
    }

    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }
}
