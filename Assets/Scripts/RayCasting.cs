using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour
{

    public Transform laserEyes;
    public float laserDuration;
    public Color laserColorStart = Color.red;
    public Color laserColorEnd = Color.green;
    public Material lineMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            RaycastHit hitInfo;
            if (Physics.Raycast(laserEyes.position, transform.forward, out hitInfo, 500)){
                DrawLine(laserEyes.position, hitInfo.point, laserColorStart, laserColorEnd, laserDuration);
                print($"Hit an object: {hitInfo.collider.name}");
            }
            else
            {

            }
        }
    }

    void DrawLine(Vector3 start, Vector3 end, Color startColor, Color endColor, float duration = 0.2f)
    {
        GameObject laser = new GameObject();
        laser.transform.position = start;
        laser.AddComponent<LineRenderer>();
        LineRenderer line = laser.GetComponent<LineRenderer>();
        line.material = lineMaterial;
        line.SetColors(startColor, endColor);
        line.SetWidth(0.1f, 0.1f);
        line.SetPosition(0, start);
        line.SetPosition(1, end);
        Destroy(laser, 2f);
    }
}
