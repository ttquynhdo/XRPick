using TMPro;
using UnityEngine;

public class PackageInfoDisplay : MonoBehaviour
{
    [Header("UI Text References")]
    public TextMeshProUGUI headerText;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI ruleText;

    private void Start()
    {
        ShowDefaultInfo();
    }

    public void ShowDefaultInfo()
    {
        headerText.text = "Instruction Panel";
        titleText.text = "";
        descriptionText.text = "";
        ruleText.text = "";
    }

    public void ShowGGInfo()
    {
        headerText.text = "Package Type";
        titleText.text = "GG (Bulk Pack)";
        descriptionText.text = "A GG package contains a fixed quantity of parts and must be handled as a complete package.";
        ruleText.text = "Rule: GG packages must NOT be opened.";
    }

    public void ShowVPEInfo()
    {
        headerText.text = "Package Type";
        titleText.text = "VPE (Packaging Unit)";
        descriptionText.text = "A VPE package contains a fixed quantity of parts. It can be picked as a full package or opened when loose items are required.";
        ruleText.text = "Rule: VPE packages CAN be opened when needed.";
    }

}