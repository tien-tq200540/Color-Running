using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorController : MonoBehaviour
{
    private SpriteRenderer playerSpriteRenderer;
    private Animator playerAnimator;

    //List of changeable player colors
    public List<Color> color = new List<Color>();
    //Default color for player
    private Color playerCurColor = Color.black;

    private void Awake()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
        playerAnimator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        color.Add(Color.red);
        color.Add(Color.green);
        color.Add(Color.blue);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (playerCurColor != color[0])
            {
                playerAnimator.SetTrigger("Change");
                playerSpriteRenderer.color = color[0];
                playerCurColor = color[0];
            } 
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (playerCurColor != color[1])
            {
                playerAnimator.SetTrigger("Change");
                playerSpriteRenderer.color = color[1];
                playerCurColor = color[1];
            }   
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (playerCurColor != color[2])
            {
                playerAnimator.SetTrigger("Change");
                playerSpriteRenderer.color = color[2];
                playerCurColor = color[2];
            }
        }
    }
}
