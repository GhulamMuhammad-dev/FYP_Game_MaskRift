// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MaskRift_ : ModuleRules
{
	public MaskRift_(ReadOnlyTargetRules Target) : base(Target)
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
			"MaskRift_",
			"MaskRift_/Variant_Platforming",
			"MaskRift_/Variant_Platforming/Animation",
			"MaskRift_/Variant_Combat",
			"MaskRift_/Variant_Combat/AI",
			"MaskRift_/Variant_Combat/Animation",
			"MaskRift_/Variant_Combat/Gameplay",
			"MaskRift_/Variant_Combat/Interfaces",
			"MaskRift_/Variant_Combat/UI",
			"MaskRift_/Variant_SideScrolling",
			"MaskRift_/Variant_SideScrolling/AI",
			"MaskRift_/Variant_SideScrolling/Gameplay",
			"MaskRift_/Variant_SideScrolling/Interfaces",
			"MaskRift_/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
