// Copyright 2017 Mike Fricker. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class StreetMapRuntime : ModuleRules
	{
        public StreetMapRuntime(ReadOnlyTargetRules Target)
			: base(Target)
		{
			PrivatePCHHeaderFile = "StreetMapRuntime.h";
			
			PrivateDependencyModuleNames.AddRange(
				new string[] {
                    "Core",
					"CoreUObject",
					"Engine",
					"RHI",
					"RenderCore",
<<<<<<< HEAD
					"ShaderCore",
                    //"PropertyEditor"
=======
                    "PropertyEditor",
>>>>>>> f973949372c85c27f85cbc2882a805922999d5ba
                }
			);
			if (Target.Version.MinorVersion <= 21)
			{
				PrivateDependencyModuleNames.AddRange(
					new string[] {
						"ShaderCore",
					}
				);
			}
			if (Target.Version.MinorVersion >= 20)
			{
				PrivateDependencyModuleNames.AddRange(
					new string[] {
						"NavigationSystem",
					}
				);
			}
		}
	}
}