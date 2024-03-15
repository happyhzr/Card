using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField] GameObject cardBack;
    [SerializeField] SceneController controller;
    //[SerializeField] Sprite image;

    private int _id;
    public int id { get { return _id; } }

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<SpriteRenderer>().sprite = image;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void UnReveal()
    {
        cardBack.SetActive(true);
    }
}
