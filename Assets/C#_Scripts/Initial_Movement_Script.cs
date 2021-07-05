using UnityEngine;

public class Initial_Movement_Script : MonoBehaviour
{
    int counter = 0;
    int speedIndex = 5;
    

    //FixedUpdate us used to process physics, no matter what FPS is.
    private void FixedUpdate()
    {
        if (counter <= 300)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speedIndex);

            counter++;
        }
        
    }
}
