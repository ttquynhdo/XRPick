using TMPro;
using UnityEngine;

public class PiecesOrderValidator : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private PiecesContainerCounter containerCounter;
    [SerializeField] private TMP_Text feedbackText;

    private void Start()
    {
        if (feedbackText != null)
        {
            feedbackText.text = "";
        }

    }

    public void ConfirmOrder()
    {
        if (containerCounter == null)
        {
            Debug.LogError("PiecesContainerCounter has not been assigned.");
            return;
        }

        int packageCount = containerCounter.FullPackageCount;
        int looseItemCount = containerCounter.LooseItemCount;
        int totalPieces = containerCounter.TotalPieces;

        if (packageCount == 2 && looseItemCount == 5)
        {
            feedbackText.text =
                    $"Correct!\n" +
                    $"{totalPieces} pieces have been placed.\n" +
                    $"Open the menu and select the next scene.";

            feedbackText.color = Color.green;
            return;
        }

        feedbackText.text =
            $"Check the order again.\n" +
            $"Packages: {packageCount} / 2\n" +
            $"Loose pieces: {looseItemCount} / 5";

        feedbackText.color = Color.red;
    }
}