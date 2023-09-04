using UnityEngine;

public class BlueShape : Shape //INHERITANCE
{
    public new void Start()
    {
        Color = Color.blue;
        base.Start(); //ABSTRACTION because you don't know what is doing it just does it
    }
    
    public override string DisplayText() //POLYMORPHISM
    {
        return "BlueShape class that inheritates from Shape";
    }
}