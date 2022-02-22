using Sandbox;
using Sandbox.UI;

[Library]
public partial class SandboxHud : HudEntity<RootPanel>
{
	public SandboxHud()
	{
		if ( !IsClient )
			return;
		
		// SCSS <STYLE>
		RootPanel.StyleSheet.Load( "/ui/SandboxHud.scss" );

		// HUD
		RootPanel.AddChild<Health>();
		RootPanel.AddChild<Armor>();
		RootPanel.AddChild<PlayerInfos>();
		RootPanel.AddChild<Crosshair>();
		RootPanel.AddChild<ChatBox>();
		RootPanel.AddChild<NameTags>();
		RootPanel.AddChild<VoiceList>();

		// Scoreboard
		RootPanel.AddChild<Scoreboard>();

		// Weapon Selector
		RootPanel.AddChild<InventoryBar>();
		RootPanel.AddChild<CurrentTool>();

		// Spawn Menu
		RootPanel.AddChild<SpawnMenu>();
		RootPanel.AddChild<modeSelect>();

		// Death
		RootPanel.AddChild<Death>();
	}
}
