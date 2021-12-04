using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{

    public void AllFruitsCollected()
    {
        if (transform.childCount==1)
        {
            Debug.Log("No quedan frutas, Victoria!");
        }
    }


}
