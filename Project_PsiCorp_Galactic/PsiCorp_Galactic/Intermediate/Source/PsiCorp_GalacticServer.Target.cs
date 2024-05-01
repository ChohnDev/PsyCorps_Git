using UnrealBuildTool;

public class PsiCorp_GalacticServerTarget : TargetRules
{
	public PsiCorp_GalacticServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("PsiCorp_Galactic");
	}
}
