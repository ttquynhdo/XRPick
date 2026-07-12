using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MixedPickingContainer : MonoBehaviour
{
    [Header("Required quantities")]
    [SerializeField] private int requiredGG = 2;
    [SerializeField] private int requiredVPE = 2;

    [Header("WMS texts")]
    [SerializeField] private TMP_Text ggCountText;
    [SerializeField] private TMP_Text vpeCountText;

    private readonly HashSet<PackageData> packagesInside = new();

    public int GGCount { get; private set; }
    public int VPECount { get; private set; }

    private void Start()
    {
        UpdateCounts();
    }

    private void OnTriggerEnter(Collider other)
    {
        PackageData package =
            other.GetComponentInParent<PackageData>();

        if (package == null)
            return;

        if (!IsCountablePackage(package.packageType))
            return;

        if (packagesInside.Add(package))
        {
            UpdateCounts();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PackageData package =
            other.GetComponentInParent<PackageData>();

        if (package == null)
            return;

        if (packagesInside.Remove(package))
        {
            UpdateCounts();
        }
    }

    private bool IsCountablePackage(PackageType type)
    {
        return type == PackageType.GG ||
               type == PackageType.VPEFull;
    }

    private void UpdateCounts()
    {
        GGCount = 0;
        VPECount = 0;

        foreach (PackageData package in packagesInside)
        {
            if (package.packageType == PackageType.GG)
            {
                GGCount++;
            }
            else if (package.packageType == PackageType.VPEFull)
            {
                VPECount++;
            }
        }

        if (ggCountText != null)
        {
            ggCountText.text =
                $"GG PLACED: {GGCount}";
        }

        if (vpeCountText != null)
        {
            vpeCountText.text =
                $"VPE PLACED: {VPECount}";
        }
    }

    public bool IsOrderCorrect()
    {
        return GGCount == requiredGG &&
               VPECount == requiredVPE;
    }
}