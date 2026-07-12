using TMPro;
using UnityEngine;

public class MixedPickingValidator : MonoBehaviour
{
    [SerializeField] private MixedPickingContainer container;
    [SerializeField] private TMP_Text feedbackText;

    private void Start()
    {

        if (feedbackText != null)
        {
            feedbackText.text = string.Empty;
        }
    }

    public void ConfirmOrder()
    {
        if (container == null)
        {
            Debug.LogError("MixedPickingContainer is not assigned.");
            return;
        }

        int gg = container.GGCount;
        int vpe = container.VPECount;

        if (gg == 2 && vpe == 2)
        {
            feedbackText.text =
                "Correct!\n2 GG and 2 VPE packages selected.";
            feedbackText.color = Color.green;

            return;
        }

        if (gg < 2 || vpe < 2)
        {
            feedbackText.text =
                    $"Check the order again.\n" +
                    $"GG: {gg} / 2\n" +
                    $"VPE: {vpe} / 2";
            feedbackText.color = Color.red;
        }
        else
        {
            feedbackText.text =
                   $"Check the order again.\n" +
                   $"GG: {gg} / 2\n" +
                   $"VPE: {vpe} / 2";
            feedbackText.color = Color.red;
        }
    }
}