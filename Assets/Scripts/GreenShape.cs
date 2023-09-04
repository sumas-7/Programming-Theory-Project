using UnityEngine;

public class GreenShape : Shape //INHERITANCE
{
    public new void Start()
    {
        Color = Color.green;
        base.Start(); //ABSTRACTION because you don't know what is doing it just does it
    }
    
    public override string DisplayText() //POLYMORPHISM
    {
        return "GreenShape class that inheritates from Shape";
    }
}