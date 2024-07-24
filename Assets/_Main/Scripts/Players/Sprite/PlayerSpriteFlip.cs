using UnityEngine;

public class PlayerSpriteFlip : MonoBehaviour
{
    private SpriteRenderer m_Sprite;

    private void Start()
    {
        m_Sprite = GetComponent<SpriteRenderer>();
    }

    public void SpriteFlip(Vector3 pos)
    {
        if (pos.x < 0)
        {
            m_Sprite.flipX = true;
        }
        else if (pos.x > 0) {
            m_Sprite.flipX = false;
        }
    }
}