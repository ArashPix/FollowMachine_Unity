using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGameobject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddSphere()
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }
    
    public void AddCube()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}
