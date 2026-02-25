// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UE5AI : ModuleRules
{
	public UE5AI(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
