using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessRiddle : MonoBehaviour
{
    public delegate void OnSuccess0();
    public static event OnSuccess0 OnSuccessAction0;

    public delegate void OnSuccess1();
    public static event OnSuccess1 OnSuccessAction1;

    public delegate void OnSuccess2();
    public static event OnSuccess2 OnSuccessAction2;

    public delegate void OnSuccess3();
    public static event OnSuccess3 OnSuccessAction3;

    private bool[] RiddlesState = new bool[4] {false, false, false, false};

    [SerializeField] GameObject Winpanel, FinalTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Success0()
    {
        OnSuccessAction0();
    }
    public void Success1()
    {
        OnSuccessAction1();
    }
    public void Success2()
    {
        OnSuccessAction2();
    }
    public void Success3()
    {
        OnSuccessAction3();
    }

    void update()
    {
        if(RiddlesState[0] == true && RiddlesState[1] == true && RiddlesState[2] == true && RiddlesState[3] == true)
        {
            
            Winpanel.SetActive(true);
            //FinalTime.SetActive(true);
        }

        
    }
}