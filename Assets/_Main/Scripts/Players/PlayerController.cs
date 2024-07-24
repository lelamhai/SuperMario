using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public InputGame m_InputGame;
    public PlayerMove m_PlayerMove;
    public PlayerAnimation m_PlayerAnimation;
    public PlayerSpriteFlip m_PlayerSpriteFlip;

    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        GetComponentInputMove();
        GetComponentAnimtion();
        GetComponentMove();
        GetComponentSpriteFlip();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        m_PlayerSpriteFlip.SpriteFlip(m_PlayerMove.Pos);
    }

    private void FixedUpdate()
    {
        m_PlayerMove.Movement(m_InputGame.KeyLeft, m_InputGame.KeyRight);
        m_PlayerAnimation.Animation(m_PlayerMove.Pos, m_InputGame.KeyLeft, m_InputGame.KeyRight);
    }

    private void LateUpdate()
    {
        
    }

    private void GetComponentInputMove()
    {
        m_InputGame = this.transform.Find("Model").GetComponent<InputGame>();
    }

    private void GetComponentAnimtion()
    {
        m_PlayerAnimation = this.transform.Find("Model").GetComponent<PlayerAnimation>();
    }

    private void GetComponentMove()
    {
        m_PlayerMove = this.transform.Find("Model").GetComponent<PlayerMove>();
    }

    private void GetComponentSpriteFlip()
    {
        m_PlayerSpriteFlip = this.transform.Find("Model").GetComponent<PlayerSpriteFlip>();
    }
}
