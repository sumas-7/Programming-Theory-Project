using UnityEngine;

public class GreenShape : Shape //INHERITANCE
{
    public new void Start()
    {
        Color = Color.green; //ABSTRACTION
        textToDisplay = "GreenShape class that inheritates from Shape"; //ABSTRACTION
        base.Start(); //ABSTRACTION because you don't know what is doing it just does it
    }
}