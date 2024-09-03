using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co.gameObject.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            FindAnyObjectByType<FruitsManeger>().AllFruitCollected();
            
            Destroy(gameObject, 0.5f);
        }
    }
}
