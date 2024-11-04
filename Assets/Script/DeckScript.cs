using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class DeckScript : MonoBehaviour
{
    public Button dealBtn;
    public Button hitBtn;
    private Animator cardAnimator;
    public Sprite[] cardSprites;
    int[] cardValues = new int[53];
    int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        GetCardValues();
        dealBtn.onClick.AddListener(() => Spin());
        hitBtn.onClick.AddListener(() => Spin());

        cardAnimator = GetComponent<Animator>();
    }

    void GetCardValues()
    {
        int num = 0;
        for (int i = 0; i < cardSprites.Length; i++)
        {
            num = i;
            num %= 13;
            if(num > 10 || num == 0)
            {
                num = 10;
            }
            cardValues[i] = num++;
        }
        
    }

    public void Shuffle()
    {
        for(int i = cardSprites.Length -1; i > 0; --i)
        {
            int j  = Mathf.FloorToInt(Random.Range(0.0f, 1.0f) * cardSprites.Length - 1) + 1;
            Sprite face = cardSprites[i];
            cardSprites[i] = cardSprites[j];
            cardSprites[j] = face;

            int value = cardValues[i];
            cardValues[i] = cardValues[j];
            cardValues[j] = value;
        }
        currentIndex = 1;
    }

    public int DealCard(CardScript cardScript)
    {
        cardScript.SetSprite(cardSprites[currentIndex]);
        cardScript.SetValue(cardValues[currentIndex]);
        currentIndex++;
        return cardScript.GetValueOfCard();
    }

    public Sprite GetCardBack()
    {
        return cardSprites[0];
    }

    private void Spin()
    {
        cardAnimator.Play("DeckSpin");
    }
}
