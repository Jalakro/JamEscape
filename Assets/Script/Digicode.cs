using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Digicode : MonoBehaviour
{
    private List<int> code = new List<int>();
    private int[] combinaison = new int[4] {5, 7, 1, 3};
    private bool validate;
    [SerializeField] private TextMeshProUGUI CodePrint;
    [SerializeField] private SuccessRiddle gameManager;
     
    public void Digits(int id)
    {
        if (code.Count > 3)
        {
            code.RemoveAt(0);
        }
        code.Add(id);
    }

    public void valid_button()
    {
        validate = true;
    }

    public void reset()
    {
        code.RemoveRange(0, code.Count);
    }
    void Start()
    {
        validate = false;
        for(int i = 0; i <4; i++)
        {
            code.Add(0);
        }
    }

    void Update()
    {
        CodePrint.GetComponent<TextMeshProUGUI>().text = $"{code[0]}{code[1]}{code[2]}{code[3]}";

        

        if (validate == true)
        {
            if (code[0] == combinaison[0] && code[1] == combinaison[1] && code[2] == combinaison[2] && code[3] == combinaison[3])
            {
                CodePrint.GetComponent<TextMeshProUGUI>().text = "Valide";
                gameManager.Success2();
            }
            else
            {
                validate = false;
                reset();
            }
        }
    }
}
