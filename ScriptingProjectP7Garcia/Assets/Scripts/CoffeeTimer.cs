using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTimer : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // when the temperature is greater than the hotlimittemperature float then...
        if(coffeeTemperature > hotLimitTemperature)
        {
            //this is the output
            print("Coffee is too hot.");
        }
        // if the temperature is less than the hot limit but less than the cold limit...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            //this is the output
            print("Coffee is too cold.");
        }

        else
        {
            print("Coffee is just right.");
        }
    }
}
