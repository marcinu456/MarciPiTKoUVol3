// Copyright The Knights of Unity. All Rights Reserved.

using UnrealBuildTool;

public class GAS : ModuleRules
{
	public GAS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput", "AIModule", "Niagara", "UMG", "GameplayAbilities" });
		PrivateDependencyModuleNames.AddRange(new string[] { "GameplayAbilities", "GameplayTags","GameplayTasks" });
	}
}
