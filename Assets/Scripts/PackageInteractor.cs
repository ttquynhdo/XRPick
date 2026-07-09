using UnityEngine;

public class PackageInteractor : MonoBehaviour
{
    public PackageInfoDisplay infoDisplay;

    private PackageData packageData;

    private void Awake()
    {
        packageData = GetComponent<PackageData>();
    }

    public void ShowInfo()
    {
        if (infoDisplay != null)
        {
            infoDisplay.ShowPackageInfo(packageData);
        }
    }
}