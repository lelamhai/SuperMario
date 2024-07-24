using UnityEngine;

public class InputPC : IInput
{
    private bool m_KeyD, m_KeyA;

    public bool KeyLeft => m_KeyD;
    public bool KeyRight => m_KeyA;

    public void InputGame()
    {
        Left();
        Right();
    }

    private void Left()
    {
        m_KeyA = Input.GetKey(KeyCode.D);
    }

    private void Right()
    { 
        m_KeyD = Input.GetKey(KeyCode.A);
    }
}
