public class InputMobile : IInput
{
    private bool m_KeyD, m_KeyA;

    public bool KeyLeft => m_KeyD;
    public bool KeyRight => m_KeyA;

    public void InputGame()
    {}

    public void OnLeft()
    {
        m_KeyA = true;
    }

    public void OneRight()
    {
        m_KeyD = true; 
    }    
}