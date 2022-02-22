using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class Health : Panel
{
	private Label HealthText;

	public Health()
	{
		Panel HealthMenu = Add.Panel( "HealthPanel" );
		HealthText = HealthMenu.Add.Label( "100", "HealthText" );
	}

	public override void Tick()
	{
		var player = Local.Pawn;
		if ( player == null ) return;

		var PlayerHealth = player.Health.CeilToInt();

		HealthText.Text = $"💖  {PlayerHealth}";
	}
}
