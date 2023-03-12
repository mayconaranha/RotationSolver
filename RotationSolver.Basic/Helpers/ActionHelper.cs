﻿using RotationSolver.Data;
using Action = Lumina.Excel.GeneratedSheets.Action;


namespace RotationSolver.Helpers;

public static class ActionHelper
{
    internal const byte GCDCooldownGroup = 58;

    public static ActionCate GetActionType(this Action action) => (ActionCate)action.ActionCategory.Value.RowId;
    internal static bool IsGeneralGCD(this Action action) => action.CooldownGroup == GCDCooldownGroup;

    internal static bool IsRealGCD(this Action action) => action.IsGeneralGCD() || action.AdditionalCooldownGroup == GCDCooldownGroup;

    internal static byte GetCoolDownGroup(this Action action)
    {
        var group = action.IsGeneralGCD() ? action.AdditionalCooldownGroup : action.CooldownGroup;
        if (group == 0) group = GCDCooldownGroup;
        return group;
    }
}