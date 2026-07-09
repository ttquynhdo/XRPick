using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenelLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void LoadGGVPEScene()
    {
        SceneManager.LoadScene("02_GG_VPE_Concept");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
