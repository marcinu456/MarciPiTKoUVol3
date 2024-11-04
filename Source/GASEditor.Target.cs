// Copyright The Knights of Unity. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class GASEditorTarget : TargetRules
{
	public GASEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.Latest;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
        ExtraModuleNames.Add("GAS");
	}
}
