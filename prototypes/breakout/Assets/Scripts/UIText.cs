using UnityEngine;
using TMPro;
public class UIText : MonoBehaviour
{

    public TMP_Text LivesText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LivesText.text = "000";
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
