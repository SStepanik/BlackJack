using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{

    public Button cardBackBtn;
    public Button startGameBtn;
    public Button rulesBtn;
    public Button cardSelectionToMenuBtn;
    public Button rulesToMenuBtn;

    public GameObject menu;
    public GameObject cardBackSelection;
    public GameObject rulesDescription;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(true);
        cardBackSelection.SetActive(false);
        rulesDescription.SetActive(false);

        cardBackBtn.onClick.AddListener(() => CardBackBtnClicked());
        startGameBtn.onClick.AddListener(() => StartGameBtClicked());
        rulesBtn.onClick.AddListener(() => RulesBtnClicked());
        cardSelectionToMenuBtn.onClick.AddListener(() => CardSelectionToMenuBtnClicked());
        rulesToMenuBtn.onClick.AddListener(() => RulesToMenuBtnClicked());

    }

    private void CardBackBtnClicked()
    {
        menu.SetActive(false);
        cardBackSelection.SetActive(true);
        rulesDescription.SetActive(false);
    }

    private void StartGameBtClicked()
    {
        menu.SetActive(false);
        cardBackSelection.SetActive(false);
        rulesDescription.SetActive(false);
        SceneManager.LoadScene("GameScene");
        //add more to change scenes
    }
    private void RulesBtnClicked()
    {
        menu.SetActive(false);
        cardBackSelection.SetActive(false);
        rulesDescription.SetActive(true);
    }
    
    private void CardSelectionToMenuBtnClicked()
    {
        menu.SetActive(true);
        cardBackSelection.SetActive(false);
        rulesDescription.SetActive(false);
    }
    private void RulesToMenuBtnClicked()
    {
        menu.SetActive(true);
        cardBackSelection.SetActive(false);
        rulesDescription.SetActive(false);
    }

}
