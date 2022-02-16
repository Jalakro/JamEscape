using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SucessRiddle : MonoBehaviour
{
    public delegate void OnSuccess0();
    public static event OnSuccess0 OnSuccesAction0;

    public delegate void OnSuccess1();
    public static event OnSuccess1 OnSuccesAction1;

    public delegate void OnSuccess2();
    public static event OnSuccess2 OnSuccesAction2;

    public delegate void OnSuccess3();
    public static event OnSuccess3 OnSuccesAction3;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Success0()
    {
        OnSuccesAction0();
    }
    public void Success1()
    {
        OnSuccesAction1();
    }
    public void Success2()
    {
        OnSuccesAction2();
    }
    public void Success3()
    {
        OnSuccesAction3();
    }
}
