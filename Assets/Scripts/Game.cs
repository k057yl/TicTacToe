using UnityEngine;

public class Game : MonoBehaviour
{
    int spriteIndex = -1;
    public int TurnPlayer()
    {
        spriteIndex++;
        return spriteIndex % 2;
    }
}
