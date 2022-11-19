using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GatherCapsules : MonoBehaviour
{
    public TMP_Text scoreText;
    public int coinsGatherd;
    private int totalcoins;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
   
    {
        if (other.CompareTag("coin") == true)
        {
            coinsGatherd = coinsGatherd + 1;
            Destroy(other.gameObject);
            print($"Total coins =" + coinsGatherd);
            scoreText.SetText("Score: " + coinsGatherd);
        }
    
    }
}
