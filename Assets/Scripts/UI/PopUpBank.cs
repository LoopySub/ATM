using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpBank : MonoBehaviour
{
    [SerializeField] private Text userName;
    [SerializeField] private Text balance;
    [SerializeField] private Text cash;
    [SerializeField] private GameObject popupError;

    private void Start()
    {
        Refresh();
    }
    
    public void Deposit(int money)
    {
        if (!GameManager.Instance.User.Deposit(money))
        {
            popupError.SetActive(true);
            return;
        }
        Refresh();
    }

    public void Withdraw(int money)
    {
        if (!GameManager.Instance.User.Withdraw(money))
        {
            popupError.SetActive(true);
            return;
        }
        Refresh();
    }

    public void CustomDeposit(InputField inputfield)
    {
        Deposit(int.Parse(inputfield.text));
    }

    public void CustomWithdraw(InputField inputfield)
    {
        Withdraw(int.Parse(inputfield.text));
    }

    private void Refresh()
    {
        userName.text = GameManager.Instance.User.Name;
        balance.text = GameManager.Instance.User.Balance.ToString();
        cash.text = GameManager.Instance.User.Cash.ToString();
    }
}
