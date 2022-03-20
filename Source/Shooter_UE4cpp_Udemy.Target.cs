// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Shooter_UE4cpp_UdemyTarget : TargetRules
{
	public Shooter_UE4cpp_UdemyTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "Shooter_UE4cpp_Udemy" } );
	}
}
