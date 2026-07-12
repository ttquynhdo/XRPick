using TMPro;
using UnityEngine;

public class PackageQuizController : MonoBehaviour
{
    [Header("Feedback UI")]
    [SerializeField] private GameObject feedbackPanel;
    [SerializeField] private TMP_Text feedbackText;

    private void Start()
    {
        feedbackPanel.SetActive(false);
    }

    public void SelectGG(bool isOn)
    {
        if (!isOn)
            return;

        feedbackPanel.SetActive(true);
        feedbackText.text = "Incorrect. GG packages must not be opened.";
        feedbackText.color = Color.red;
    }

    public void SelectVPE(bool isOn)
    {
        if (!isOn)
            return;

        feedbackPanel.SetActive(true);
        feedbackText.text = "Correct! VPE packages can be opened.";
        feedbackText.color = Color.green;
    }

    public void SelectBoth(bool isOn)
    {
        if (!isOn)
            return;

        feedbackPanel.SetActive(true);
        feedbackText.text = "Incorrect. Only VPE packages can be opened.";
        feedbackText.color = Color.red;
    }
}