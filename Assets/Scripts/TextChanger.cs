using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextChanger : MonoBehaviour
{
    public TMP_Text text;
    public TMP_InputField inputField;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = inputField.text;
    }
}
