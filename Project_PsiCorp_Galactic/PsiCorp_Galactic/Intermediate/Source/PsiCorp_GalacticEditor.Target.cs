using UnrealBuildTool;

public class PsiCorp_GalacticEditorTarget : TargetRules
{
	public PsiCorp_GalacticEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("PsiCorp_Galactic");
	}
}
