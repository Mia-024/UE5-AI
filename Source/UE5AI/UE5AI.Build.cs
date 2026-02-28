// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UE5AI : ModuleRules
{
	public UE5AI(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UE5AI",
			"UE5AI/Variant_Platforming",
			"UE5AI/Variant_Platforming/Animation",
			"UE5AI/Variant_Combat",
			"UE5AI/Variant_Combat/AI",
			"UE5AI/Variant_Combat/Animation",
			"UE5AI/Variant_Combat/Gameplay",
			"UE5AI/Variant_Combat/Interfaces",
			"UE5AI/Variant_Combat/UI",
			"UE5AI/Variant_SideScrolling",
			"UE5AI/Variant_SideScrolling/AI",
			"UE5AI/Variant_SideScrolling/Gameplay",
			"UE5AI/Variant_SideScrolling/Interfaces",
			"UE5AI/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
