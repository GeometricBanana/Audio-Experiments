using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{

    public TMP_Text displayName; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(displayName.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
