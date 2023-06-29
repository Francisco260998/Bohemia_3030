using UnrealBuildTool;

public class BohemiaTarget : TargetRules
{
	public BohemiaTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Bohemia");
	}
}
