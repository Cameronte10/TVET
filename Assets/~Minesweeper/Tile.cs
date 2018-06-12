using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    // Use this for initialization
    public int x, y;
    public bool isMine = false;
    public bool isRevealed = false;
    [Header("References")]
    public Sprite[] emptySprites;
    public Sprite[] mineSprites;
    private SpriteRenderer rend;

    void Awake()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        isMine = Random.value < .05f;
    }

    public void Reveal(int adjacentMines, int mineState = 0)
    {
        isRevealed = true;

        if(isMine)
        {
            rend.sprite = mineSprites[mineState];
        }
        else
        {
            rend.sprite = emptySprites[adjacentMines];
        }
    }
}
