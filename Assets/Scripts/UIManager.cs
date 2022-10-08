using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TestPlayer player;

    public void CallFoo()
    {
        player.Foo();
    }

    public void CallCommandFoo()
    {
        player.CMDFoo();
    }
}
