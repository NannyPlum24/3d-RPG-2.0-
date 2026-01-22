using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject1 : MonoBehaviour
{
    public string ItemName;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            // do things ;)

            GetItemName();
        }
       

      
    }

    public string GetItemName()
    {

        Debug.Log(ItemName);
        return ItemName;

    }
}