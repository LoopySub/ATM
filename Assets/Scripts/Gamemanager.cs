using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.TerrainTools;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance;
    public Text _balance;
    public Text _cash;
    public GameObject BGUI;
    public GameObject DepositUi;
    public GameObject WithdrawUi;

    
    
     void Awake()
    {
        Instance = this;
        _balance.text = "50000";
        _cash.text = "100000";

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    public void GoDeposit()
    {
        BGUI.SetActive(false);
        DepositUi.SetActive(true);
        WithdrawUi.SetActive(false);
    }

    public void GoHome()
    {
        BGUI.SetActive(true);
        DepositUi.SetActive(false);
        WithdrawUi.SetActive(false);
    }

    public void GoWithdraw()
    {
        BGUI.SetActive(false);
        DepositUi.SetActive(false);
        WithdrawUi.SetActive(true);
    }

}
