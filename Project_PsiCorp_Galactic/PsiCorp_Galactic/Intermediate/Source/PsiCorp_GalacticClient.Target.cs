using UnrealBuildTool;

public class PsiCorp_GalacticClientTarget : TargetRules
{
	public PsiCorp_GalacticClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("PsiCorp_Galactic");
	}
}
