using UnrealBuildTool;

public class PsiCorp_GalacticTarget : TargetRules
{
	public PsiCorp_GalacticTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("PsiCorp_Galactic");
	}
}
