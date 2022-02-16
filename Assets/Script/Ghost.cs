using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    Vector3 vect;
    Vector3 tmp;
    // Start is called before the first frame update
    [SerializeField] GameObject ghosted;
    void Start()
    {
        vect = ghosted.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tmp = ghosted.transform.position - vect;
        
        transform.position = transform.position + new Vector3(-tmp.z, tmp.y, tmp.x);
    }
}
