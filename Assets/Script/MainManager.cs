using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainManager : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static MainManager Instance;
    public Button greenCardBtn;
    public Button redCardBtn;
    public Button blueCardBtn;
    public int cardcol = 1;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        
        greenCardBtn.onClick.AddListener(() => GreenCardBtnClicked());
        redCardBtn.onClick.AddListener(() => RedCardBtnClicked());
        blueCardBtn.onClick.AddListener(() => BlueCardBtnClicked());
    }
    private void GreenCardBtnClicked()
    {
        cardcol = 1;
    }
    private void RedCardBtnClicked()
    {
        cardcol = 2;
    }
    private void BlueCardBtnClicked()
    {
        cardcol = 3;
    }
}
