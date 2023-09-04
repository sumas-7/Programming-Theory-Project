using UnityEngine;

public class BlueShape : Shape //INHERITANCE
{
    public new void Start()
    {
        Color = Color.blue; //ABSTRACTION
        textToDisplay = "BlueShape class that inheritates from Shape"; //ABSTRACTION
        base.Start(); //ABSTRACTION because you don't know what is doing it just does it
    }
}