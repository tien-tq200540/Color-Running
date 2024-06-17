using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorControl : MonoBehaviour
{
    private SpriteRenderer playerSpriteRenderer;
    private Animator playerAnimator;

    //List of changeable player colors
    public List<Color> color = new List<Color>();

    private void Awake()
    {
        playerSpriteRenderer = GetComponent<SpriteRenderer>();
        playerAnimator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        color.Add(Color.red);
        color.Add(Color.green);
        color.Add(Color.blue);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerAnimator.SetTrigger("Change");
            playerSpriteRenderer.color = color[0];
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerAnimator.SetTrigger("Change");
            playerSpriteRenderer.color = color[1];
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            playerAnimator.SetTrigger("Change");
            playerSpriteRenderer.color = color[2];
        }
    }
}
