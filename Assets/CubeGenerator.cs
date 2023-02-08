using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{

    static GameObject cube;
    float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        // GameObject.CreatePrimitive(PrimitiveType.Cube);

        // GameObject cube;

        // instantiate 
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // set position
        cube.transform.position = new Vector3(0.0f, 0.5f, 0.0f);

    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
