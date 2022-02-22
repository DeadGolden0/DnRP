using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class Armor : Panel
{
	private Label ArmorText;

	public Armor()
	{
		Panel ArmorMenu = Add.Panel( "ArmorPanel" );
		ArmorText = ArmorMenu.Add.Label( "100", "ArmorText" );
	}

	public override void Tick()
	{
		var player = Local.Pawn as SandboxPlayer;
		if ( player == null ) return;

		var PlayerArmor = player.Armor.CeilToInt();
		//var ba = (armor >= 100 ? "" : (armor >= 10 ? "0" : "00")) + armor;

		ArmorText.Text = $"🛡️  {PlayerArmor}";
	}
}
