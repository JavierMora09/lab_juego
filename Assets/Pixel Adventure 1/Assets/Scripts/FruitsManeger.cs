using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsManeger : MonoBehaviour
{
 
    public void AllFruitCollected(){

        if (transform.childCount == 1)
        {
            Debug.Log("no quedan frutas, victoria");            
        }
    }


}
