using UnityEngine;

public class Shape : MonoBehaviour
{
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
        TEXT.Text = DisplayText();
    }

    public virtual string DisplayText()
    {
        return "Base shape class, colored black";
    }
}