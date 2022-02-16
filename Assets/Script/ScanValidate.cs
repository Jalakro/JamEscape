using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ScanValidate : MonoBehaviour
{
    public short ScanID;
    [SerializeField] private SucessRiddle SuccessManager;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void fonc (HoverEnterEventArgs args)
    {
        if (args.interactableObject.transform.tag == $"{ScanID}")
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
            if (ScanID == 0)
                SuccessManager.Success0();
            if (ScanID == 1)
                SuccessManager.Success1();
            if (ScanID == 2)
                SuccessManager.Success2();
            if (ScanID == 3)
                SuccessManager.Success3();
        }
        if (args.interactableObject.transform.tag != $"{ScanID}")
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}
