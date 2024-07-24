using System.Collections;
using TMPro;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class PlayerAnimation : MonoBehaviour
{
    private Animator m_Animator;
    private SpriteRenderer m_Sprite;

    private void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Sprite = GetComponent<SpriteRenderer>();
    }

    public void Animation(Vector3 pos, bool keyA, bool keyD)
    {

        m_Animator.SetLayerWeight(m_Animator.GetLayerIndex("Small"), 0);
        m_Animator.SetFloat("Run", Mathf.Abs(pos.x));
        bool skidding = false;

        if (keyA)
        {
            if (pos.x > 0)
            {
                skidding = true;
            }
        }
        if (keyD) 
        {
            if (pos.x < 0)
            {
                skidding = true;
            }
        }

        m_Animator.SetBool("Skidding", skidding);
    }

    //private bool keySpace, m_KeyD, m_KeyA, keyShift, keySpaceDown;
    //private const float conversion = 65536; // == 0x10000
    //private const float maxRunX = 10496 / conversion;
    //private const float maxWalkX = 6400 / conversion;
    //private const float walkAcc = 152 / conversion;
    //private const float runAcc = 228 / conversion;

    //private const float skidPower = 416 / conversion;
    //private const float releaseDeAcc = 208 / conversion;

    //private const float fastJumpPower = 20480 / conversion;
    //private const float jumpPower = 16384 / conversion;

    //private const float fastJumpReq = 9472 / conversion;
    //private const float modJumpReq = 4096 / conversion;

    //private const float fastJumpDecay = 2304 / conversion;
    //private const float fastJumpDecayUp = 640 / conversion;
    //private const float modJumpDecay = 1536 / conversion;
    //private const float modJumpDecayUp = 460 / conversion; // 480
    //private const float slowJumpDecay = 1792 / conversion;
    //private const float slowJumpDecayUp = 490 / conversion; //512

    //private const float airStrafeBorder = 6400 / conversion;
    //private const float airStrafeFast = 7424 / conversion;

    //private const float goombaJump = 18432 / conversion;

    //private void Update()
    //{
    //    m_KeyD = Input.GetKey(KeyCode.D);
    //    m_KeyA = Input.GetKey(KeyCode.A);
    //}

    //private void LateUpdate()
    //{
    //    bool skidding = false;

    //    if (m_KeyD)
    //    {
    //        if (m_pos.x >= 0)
    //        {
    //            m_pos.x += walkAcc;
    //        }
    //        else if (m_pos.x < 0)
    //        {
    //            m_pos.x += skidPower;
    //            skidding = true;
    //        }
    //    }

    //    if (m_KeyA)
    //    {
    //        if (m_pos.x <= 0)
    //        {
    //            m_pos.x -= walkAcc;
    //        }
    //        else if (m_pos.x > 0)
    //        {
    //            m_pos.x -= skidPower;
    //            skidding = true;
    //        }
    //    }

    //    if (m_pos.x > 0)
    //    {
    //        m_Sprite.flipX = skidding;
    //    }
    //    else if (m_pos.x < 0)
    //    {
    //        m_Sprite.flipX = !skidding;
    //    }

    //    Move(m_pos);

    //    m_Animator.SetBool("Skidding", skidding);
    //}


    //private void Move(Vector2 move)
    //{
    //    m_rigidbody2D.velocity = new Vector2(move.x * m_speed, move.y);
    //}

}
