using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0.0f, 0);
        cube.AddComponent<movement>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

}
