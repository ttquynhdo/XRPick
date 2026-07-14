using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PiecesContainerCounter : MonoBehaviour
{
    [Header("Order settings")]
    [SerializeField] private int piecesPerPackage = 25;
    [SerializeField] private int requiredPieces = 55;

    [Header("Display")]
    [SerializeField] private TMP_Text piecesPlacedText;

    private readonly HashSet<PackageData> objectsInside = new();

    public int FullPackageCount { get; private set; }
    public int LooseItemCount { get; private set; }

    public int TotalPieces =>
        (FullPackageCount * piecesPerPackage) + LooseItemCount;

    private void Start()
    {
        Recalculate();
    }

    private void OnTriggerEnter(Collider other)
    {
        PackageData item = other.GetComponentInParent<PackageData>();

        if (item == null)
            return;

        if (!IsAcceptedType(item.packageType))
            return;

        if (objectsInside.Add(item))
        {
            Recalculate();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PackageData item = other.GetComponentInParent<PackageData>();

        if (item == null)
            return;

        if (objectsInside.Remove(item))
        {
            Recalculate();
        }
    }

    private bool IsAcceptedType(PackageType type)
    {
        return type == PackageType.VPEFull ||
               type == PackageType.LooseItemDisplay;
    }

    private void Recalculate()
    {
        FullPackageCount = 0;
        LooseItemCount = 0;

        foreach (PackageData item in objectsInside)
        {
            if (item.packageType == PackageType.VPEFull)
            {
                FullPackageCount++;
            }
            else if (item.packageType == PackageType.LooseItemDisplay)
            {
                LooseItemCount++;
            }
        }

        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (piecesPlacedText != null)
        {
            piecesPlacedText.text =
                $"PIECES PLACED: {TotalPieces} / {requiredPieces}";
        }
    }

    public bool IsCorrect()
    {
        return FullPackageCount == 2 &&
               LooseItemCount == 5;
    }
}