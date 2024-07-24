using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D m_rigidbody2D;
    private float m_speed = 5;
    private Vector3 m_Pos;
    public Vector3 Pos => m_Pos;

    private const float conversion = 65536; // == 0x10000
    private const float maxRunX = 10496 / conversion;
    private const float maxWalkX = 6400 / conversion;
    private const float walkAcc = 152 / conversion;
    private const float runAcc = 228 / conversion;

    private const float skidPower = 416 / conversion;
    private const float releaseDeAcc = 208 / conversion;

    private const float fastJumpPower = 20480 / conversion;
    private const float jumpPower = 16384 / conversion;

    private const float fastJumpReq = 9472 / conversion;
    private const float modJumpReq = 4096 / conversion;

    private const float fastJumpDecay = 2304 / conversion;
    private const float fastJumpDecayUp = 640 / conversion;
    private const float modJumpDecay = 1536 / conversion;
    private const float modJumpDecayUp = 460 / conversion; // 480
    private const float slowJumpDecay = 1792 / conversion;
    private const float slowJumpDecayUp = 490 / conversion; //512

    private const float airStrafeBorder = 6400 / conversion;
    private const float airStrafeFast = 7424 / conversion;

    private const float goombaJump = 18432 / conversion;

    private void Start()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Movement(bool keyA, bool keyD)
    {
        if (keyA)
        {
            if (m_Pos.x <= 0)
            {
                m_Pos.x -= walkAcc;
            }
            else if (m_Pos.x > 0)
            {
                m_Pos.x -= skidPower;
            }
        }

        if (keyD)
        {
            if (m_Pos.x >= 0)
            {
                m_Pos.x += walkAcc;
            }
            else if (m_Pos.x < 0)
            {
                m_Pos.x += skidPower;
            }
        }

        if (!keyA && !keyD)
        {
            m_Pos.x = 0;
        }

        float maxSpeed = maxWalkX;
        if (m_Pos.x > maxSpeed)
        {
            m_Pos.x = maxSpeed;
        }
        else if (m_Pos.x < -maxSpeed)
        {
            m_Pos.x = -maxSpeed;
        }

        Move(m_Pos);
    }

    private void Move(Vector2 move)
    {
        transform.position += new Vector3(move.x, move.y, 0);
    }
}