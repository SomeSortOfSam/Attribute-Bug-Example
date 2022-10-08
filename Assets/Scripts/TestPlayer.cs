using Mirror;
using UnityEngine;

public class TestPlayer : NetworkBehaviour
{
    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        FindObjectOfType<UIManager>().player = this;
    }

    public void Foo()
    {
        ServerFoo();
        ClientFoo();
    }

    [Command]
    public void CMDFoo()
    {
        ServerFoo();
        ClientFoo();
    }

    [ServerCallback]
    private void ServerFoo()
    {
        Debug.LogError("Server Called");
    }

    [ClientCallback]
    private void ClientFoo()
    {
        Debug.LogError("Client Called");
    }
}
