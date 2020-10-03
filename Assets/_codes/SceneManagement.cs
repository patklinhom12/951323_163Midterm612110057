using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    public int idScene;
    public void StageSelectionButtonClick(Button button)
    {
        SceneManager.LoadScene("StageSelection");
    }

    public void OptionButtonClick(Button button)
    {
        if (!SingletonManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("Option", LoadSceneMode.Additive);
            SingletonManager.Instance.IsOptionMenuActive = true;
        }
    }

    public void CreditButtonClick(Button button)
    {
        SceneManager.LoadScene("Credit");
    }

    public void Stage1ButtonClick(Button button)
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Stage2ButtonClick(Button button)
    {
        SceneManager.LoadScene("Stage2");
    }

    public void BackToMenuButtonClick(Button button)
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void BackStageSelectionClick(Button button)
    {
        SceneManager.LoadScene("StageSelection");
    }

    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.anyKey && idScene == 1)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void BackButtonClick(Button button)
    {
        SceneManager.UnloadSceneAsync("Option");
        SingletonManager.Instance.IsOptionMenuActive = false;
    }
}
