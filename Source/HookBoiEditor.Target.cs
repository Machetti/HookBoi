

using UnrealBuildTool;
using System.Collections.Generic;

public class HookBoiEditorTarget : TargetRules
{
	public HookBoiEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "HookBoi" } );
	}
}
