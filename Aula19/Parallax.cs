using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    float vel = 12f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(new Vector3(0, -vel * Time.deltaTime, 0));
    }
}
