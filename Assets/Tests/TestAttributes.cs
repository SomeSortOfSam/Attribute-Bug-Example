using Mirror;
using Mirror.Tests;
using NUnit.Framework;

public class TestAttributes : MirrorEditModeTest
{
    NetworkConnectionToClient connectionToClient;
    TestPlayer playerServer;
    TestPlayer playerClient;

    [SetUp]
    public override void SetUp()
    {
        base.SetUp();

        // start server/client
        NetworkServer.Listen(1);
        ConnectClientBlockingAuthenticatedAndReady(out connectionToClient);

        CreateNetworkedAndSpawn(out _, out _, out playerServer,
        out _, out _, out playerClient,
        connectionToClient);
    }

    [Test]
    public void TestServerCallbackAttributes()
    {
        playerClient.CMDFoo();
        ProcessMessages();
    }

    [Test]
    public void TestClientCallbackAttributes()
    {
        playerClient.Foo();
    }
}
