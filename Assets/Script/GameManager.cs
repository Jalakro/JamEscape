using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SucessRiddle.OnSuccesAction0 += MoveDoor0;
        SucessRiddle.OnSuccesAction1 += MoveDoor1;
        SucessRiddle.OnSuccesAction2 += MoveDoor2;
        SucessRiddle.OnSuccesAction3 += MoveDoor3;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void MoveDoor0()
    {
        StartCoroutine(Deplacerporte(0));
    }
    private void MoveDoor1()
    {
        StartCoroutine(Deplacerporte(1));
    }
    private void MoveDoor2()
    {
        StartCoroutine(Deplacerporte(2));
    }
    private void MoveDoor3()
    {
        StartCoroutine(Deplacerporte(3));
    }


    private IEnumerator Deplacerporte(short id)
    {
        for (int i=0; i<100; i++)
        {
            transform.GetChild(id).gameObject.transform.Translate(new Vector3(-0.01f, 0f, 0f));
            yield return new WaitForSeconds(.005f);
        }
    }
}
