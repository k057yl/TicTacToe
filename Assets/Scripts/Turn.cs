using UnityEngine;

public class Turn : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject grid;
    public Sprite[] images;
    bool unPlayed = true;
    private void Start()
    {
        spriteRenderer.sprite = null;
    }
    private void OnMouseDown()
    {
        if(unPlayed)
        {
            int index = grid.GetComponent<Game>().TurnPlayer();
            spriteRenderer.sprite = images[index];
            unPlayed = false;
        }
        
    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        grid = GameObject.Find("Grid");
    }
}
