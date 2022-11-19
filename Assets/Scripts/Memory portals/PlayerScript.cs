using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int playerNumber;
    public int gatenumber;
    public GameObject previousGameObject;
  void Awake()
    {
        playerNumber = -1;
        previousGameObject = new GameObject();
    }
    
    void OnTriggerEnter(Collider other)
    {
        //Deze if statement zet de playernumber gelijk aan de gate waar die mee interact (als de playernumber -1 is heeft de player nog nergens mee geinteract en als die boven de -1 is heeft ie ergens mee geinteract)
        if (other.gameObject.TryGetComponent(out Portalsmemory portalsmemory)&& other.gameObject.name != previousGameObject.name)
        {
            int gatenumber = portalsmemory.Getnumber();
            //print(gatenumber);
            if (playerNumber == -1)
            {
                previousGameObject = other.gameObject;
                playerNumber = gatenumber;
                //print($"playernumber is {playerNumber}");
            }
            //deze else if statement controlleert of de waarde van de playernumber gelijk is aan de gate waarmee die interact, zo ja dan destroyt ie de gate en feliciteert ie je, anders is t fout
            else if (playerNumber > -1)
            {
                if (playerNumber == gatenumber)
                {
                    print($"Gefeliciteerd!!");
                    playerNumber = -1;
                    Destroy(other.gameObject);
                    Destroy(previousGameObject);
                    previousGameObject = new GameObject();
                }
                else
                {
                    print($"Verkeerde Gate!");
                    playerNumber = -1;
                    previousGameObject = new GameObject();
                }
            }
        }        
    }
}