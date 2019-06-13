

using UnrealBuildTool;
using System.Collections.Generic;

public class HookBoiTarget : TargetRules
{
	public HookBoiTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "HookBoi" } );
	}
}
