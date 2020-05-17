using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timers : MonoBehaviour
{
    #region Fields
    public float NexTime = 0;
    public int Counter = 10;
    public int Timer = 3;
    public int minHeight = 1;
    public int maxHeight = 10;
    public int verticalSpacing = 1;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    // Update is called once per frame
    void Update()
    {
        
        int horizontalSpacing = Random.Range(1, 3);
        if (Counter > 0 && Time.fixedTime > NexTime) // controls the interval that the box is built
        {
            NexTime = Time.fixedTime + Timer;
           
            for (int j = 10; j > 0; j--)
            {
                int randomNumber = Random.Range(minHeight, maxHeight);
                for (int i = 0; i < randomNumber; i++)
                {
                    CustomBox box = new CustomBox();
                    box.box.transform.position = new Vector3(Counter * verticalSpacing, i * verticalSpacing, j * verticalSpacing);
                    int randomNumber1 = Random.Range(1, 4);
                    box.box.transform.localScale = new Vector3(randomNumber1, randomNumber1, randomNumber1);
                    

                }
            }
            Counter--;
        }
    }

    class CustomBox
    {
        public GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
    }

}
