using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input : MonoBehaviour
{
    [SerializeField] private Text txt_money;
    [SerializeField] private InputField inputTxT_Money;//inputMoney�� inputfield.
    private int current_Money;



    public void Start()
    {
       
        current_Money = int.Parse(txt_money.text); 
    }
    public void InputCash() //�Ա�

    {
       
        current_Money -= int.Parse(inputTxT_Money.text); //�Է¹��� ������ ���ڸ� int�� ���ڷ� �ٲ���.

        
    }

    public void OutputCash() //���
    {

        current_Money += int.Parse(inputTxT_Money.text); //������ ���ڸ� int�� ���ڷ� �ٲ���.

    }
}
