using UnityEngine;

public class InputGame : MonoBehaviour
{
    private bool m_KeyD, m_KeyA;
    public bool KeyLeft => m_KeyD;
    public bool KeyRight => m_KeyA;

    private void Update()
    {
        m_KeyA = Input.GetKey(KeyCode.D);
        m_KeyD = Input.GetKey(KeyCode.A);
    }

    public void Left()
    {
        m_KeyD = true;
    }

    public void Right()
    {
        m_KeyA = true;
    }
}