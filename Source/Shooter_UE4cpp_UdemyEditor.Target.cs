// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Shooter_UE4cpp_UdemyEditorTarget : TargetRules
{
	public Shooter_UE4cpp_UdemyEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "Shooter_UE4cpp_Udemy" } );
	}
}
