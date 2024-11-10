using UnrealBuildTool;

public class FinalMapExportTarget : TargetRules
{
	public FinalMapExportTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FinalMapExport");
	}
}
