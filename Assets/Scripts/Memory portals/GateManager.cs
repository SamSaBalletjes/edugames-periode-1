using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).TryGetComponent(out Portalsmemory portalsmemory))
            {
                portalsmemory.Setnumber((i+1) % transform.childCount / 2);
                print($"portalsmemorynumber = {portalsmemory.Getnumber()}");
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
