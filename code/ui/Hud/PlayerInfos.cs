using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class PlayerInfos : Panel
{
    public Image Avatar;
    public Label PlayerName;
    public Label JobName;
    public Label WalletValue;
    public Label SalaryValue;

	public PlayerInfos()
	{
		Panel InfosMenu = Add.Panel( "InfosMenu" );
        Avatar = InfosMenu.Add.Image( $"avatar:{Local.SteamId}" );
        Avatar.AddClass("Avatar");

        Panel TextInfosMenu = InfosMenu.Add.Panel( "TextInfosMenu" );
        PlayerName = TextInfosMenu.Add.Label("👤  Hayden Johnson", "PlayerName");

        JobName = TextInfosMenu.Add.Label("💼  Chomeur", "JobName");

        WalletValue = TextInfosMenu.Add.Label("💵  $1500", "WalletValue");
	}

	public override void Tick()
	{
		var player = Local.Pawn as SandboxPlayer;
		if ( player == null ) return;
	}
}
