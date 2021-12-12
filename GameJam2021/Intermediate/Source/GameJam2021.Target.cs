using UnrealBuildTool;

public class GameJam2021Target : TargetRules
{
	public GameJam2021Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameJam2021");
	}
}
