using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSentience : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //felt kinda commenty or in other words this page needs a hero comment attack

        /*multi line comment lollll
         * cool right
         * */
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
