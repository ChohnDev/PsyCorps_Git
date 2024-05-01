using UnrealBuildTool;

public class PsiCorp_Galactic : ModuleRules
{
	public PsiCorp_Galactic(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
