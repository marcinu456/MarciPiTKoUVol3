// Copyright The Knights of Unity. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GASTarget : TargetRules
{
	public GASTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.Add("GAS");
	}
}
