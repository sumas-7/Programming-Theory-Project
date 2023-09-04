using UnityEngine;

public class RedShape : Shape //INHERITANCE
{
    public new void Start()
    {
        Color = Color.red; //ABSTRACTION
        textToDisplay = "RedShape class that inheritates from Shape"; //ABSTRACTION
        base.Start(); //ABSTRACTION because you don't know what is doing it just does it
    }
}