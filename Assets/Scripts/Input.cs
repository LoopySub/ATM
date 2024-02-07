using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input : MonoBehaviour
{
    [SerializeField] private Text txt_money;
    [SerializeField] private InputField inputTxT_Money;//inputMoney는 inputfield.
    private int current_Money;



    public void Start()
    {
       
        current_Money = int.Parse(txt_money.text); 
    }
    public void InputCash() //입금

    {
       
        current_Money -= int.Parse(inputTxT_Money.text); //입력받은 문자형 숫자를 int형 숫자로 바꿔줌.

        
    }

    public void OutputCash() //출금
    {

        current_Money += int.Parse(inputTxT_Money.text); //문자형 숫자를 int형 숫자로 바꿔줌.

    }
}
