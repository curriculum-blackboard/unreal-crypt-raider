﻿using UnrealBuildTool;


public class FirstPersonTemplate : ModuleRules
{
    public FirstPersonTemplate(ReadOnlyTargetRules inTarget) : base(inTarget)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(new string[]
        {
        });


        PrivateIncludePaths.AddRange(new string[]
        {
        });


        PublicDependencyModuleNames.AddRange(new string[]
        {
            "Core",
        });

        PrivateDependencyModuleNames.AddRange(new string[]
        {
            "CoreUObject",
            "Engine",
        });


        DynamicallyLoadedModuleNames.AddRange(new string[]
        {
        });
    }
}
