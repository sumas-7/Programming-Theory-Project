using UnityEngine;

public class Shape : MonoBehaviour
{
    /* as you can probably see from my previous commit, this was once a function called "DisplayText()" that just returned a string 
    The function was overriden in every other class, but i realized this was a muche better and ABSTRACT way of doing it, therefore i changed to a variable*/
    protected string textToDisplay = "Base shape class, colored black";

    private new MeshRenderer renderer;

    // ENCAPSULATION i guess
    private Color color = Color.black;
    public Color Color
    {
        get{ return color; }
        set{ color = value; }
    }

    public void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.material.color = color;
    }

    private void OnMouseDown()
    {
        TEXT.Text = textToDisplay;
    }
}