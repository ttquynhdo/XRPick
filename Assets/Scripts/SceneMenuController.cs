using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenuController : MonoBehaviour
{
    public void OpenWelcome(bool isOn)
    {
        if (!isOn)
            return;

        SceneManager.LoadScene("WelcomeScene");
    }

    public void OpenConcept(bool isOn)
    {
        if (!isOn)
            return;

        SceneManager.LoadScene("ConceptScene");
    }

    public void OpenBasicPicking(bool isOn)
    {
        if (!isOn)
            return;

        SceneManager.LoadScene("BasicPickingScene");
    }

    public void OpenMixedPicking(bool isOn)
    {
        if (!isOn)
            return;

        SceneManager.LoadScene("MixedPickingScene");
    }

    public void OpenComplex(bool isOn)
    {
        if (!isOn)
            return;

        SceneManager.LoadScene("ComplexScene");
    }

    public void ExitTraining(bool isOn)
    {
        if (!isOn)
            return;

        Debug.Log("Exit training");

        Application.Quit();
    }
}