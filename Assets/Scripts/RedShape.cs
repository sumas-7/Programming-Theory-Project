using UnityEngine;

public class RedShape : Shape //INHERITANCE
{
    public new void Start()
    {
        Color = Color.red;
        base.Start();  //ABSTRACTION because you don't know what is doing it just does it
    }
    
    public override string DisplayText() //POLYMORPHISM
    {
        return "RedShape class that inheritates from Shape";
    }
}