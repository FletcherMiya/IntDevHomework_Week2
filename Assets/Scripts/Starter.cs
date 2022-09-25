using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{

    public GameObject startobj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CurrentPosition = startobj.transform.position;
        if (Input.GetKeyDown("w"))
        {
            CurrentPosition.y += 500;
        }
        startobj.transform.position = CurrentPosition;
    }
}
