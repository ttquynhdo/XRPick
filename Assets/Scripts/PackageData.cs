using UnityEngine;

public class PackageData : MonoBehaviour
{
    public enum PackageType
    {
        GG,
        VPE
    }

    public PackageType packageType;

    [TextArea]
    public string description;

    [TextArea]
    public string rule;
}