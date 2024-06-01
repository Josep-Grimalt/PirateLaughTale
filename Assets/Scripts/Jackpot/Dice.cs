using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeSprite(int num)
    {
        switch (num)
        {
            case 1:
                spriteRenderer.sprite = sprites[0];
                break;
            case 2:
                spriteRenderer.sprite = sprites[1];
                break;
            case 3:
                spriteRenderer.sprite = sprites[2];
                break;
            case 4:
                spriteRenderer.sprite = sprites[3];
                break;
            case 5:
                spriteRenderer.sprite = sprites[4];
                break;
            case 6:
                spriteRenderer.sprite = sprites[5];
                break;
        }
    }
}
