[Icon("favorite")]
public class PlayerStats : Component
{
	[Property, Group("Variables")]
	public float Health { get; set; } = 100f;
	[Property, Group("Variables")]
	public float MaxHealth { get; set; } = 100f;
	[Property, Group("Variables")]
	public float Resistance { get; set; } = 0f;
}
