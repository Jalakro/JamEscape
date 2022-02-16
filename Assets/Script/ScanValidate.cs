using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanValidate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SucessRiddle.OnSuccesAction0 += Validation;
    }

    public void Validation()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
