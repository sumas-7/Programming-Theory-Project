using UnityEngine;
using TMPro;

public class TEXT : MonoBehaviour
{
    // more ENCAPSULATION i guess
    private static TMP_Text text;
    public static string Text
    {
        get{ return text.text; }
        set{ text.text = value; }
    }

    private void Start()
    {
        text = GetComponent<TMP_Text>();
    }
}