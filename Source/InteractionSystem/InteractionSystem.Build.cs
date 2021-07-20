// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class InteractionSystem : ModuleRules
{
	public InteractionSystem(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicIncludePaths.AddRange(
		new string[] {
				"InteractionDemo"
			}
		);

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"GameplayAbilities",
			"GameplayTasks",
			"GameplayTags",
			"ModularGameplay",
			"EnhancedInput",
			"Interaction"
		});

		PrivateDependencyModuleNames.AddRange(new string[] {
			"GameFeatures",
			"RenderCore",
			"SlateCore",
			"ModularGameplay"
		});
	}
}
