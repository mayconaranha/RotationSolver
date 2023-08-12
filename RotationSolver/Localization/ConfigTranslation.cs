﻿using RotationSolver.Basic.Configuration;

namespace RotationSolver.Localization;

internal static class ConfigTranslation
{
    public static string ToName(this JobConfigInt config) => config switch
    {
        JobConfigInt.AddDotGCDCount => LocalizationManager.RightLang.ConfigWindow_Param_AddDotGCDCount,
        _ => string.Empty,
    };

    public static string ToName(this JobConfigFloat config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToName(this PluginConfigInt config) => config switch
    {
        // UI
        PluginConfigInt.KeyBoardNoiseMin => LocalizationManager.RightLang.ConfigWindow_Param_KeyBoardNoiseTimes,
        PluginConfigInt.LessMPNoRaise => LocalizationManager.RightLang.ConfigWindow_Param_LessMPNoRaise,
        PluginConfigInt.CooldownActionOneLine => LocalizationManager.RightLang.ConfigWindow_Control_CooldownActionOneLine,
        _ => string.Empty,
    };

    public static string ToName(this PluginConfigBool config) => config switch
    {
        // basic
        PluginConfigBool.AutoOffBetweenArea => LocalizationManager.RightLang.ConfigWindow_Param_AutoOffBetweenArea,
        PluginConfigBool.AutoOffCutScene => LocalizationManager.RightLang.ConfigWindow_Param_AutoOffCutScene,
        PluginConfigBool.AutoOffWhenDead => LocalizationManager.RightLang.ConfigWindow_Param_AutoOffWhenDead,
        PluginConfigBool.StartOnCountdown => LocalizationManager.RightLang.ConfigWindow_Param_StartOnCountdown,
        PluginConfigBool.StartOnAttackedBySomeone => LocalizationManager.RightLang.ConfigWindow_Param_StartOnAttackedBySomeone,
        PluginConfigBool.UseWorkTask => LocalizationManager.RightLang.ConfigWindow_Param_UseWorkTask,
        PluginConfigBool.ToggleManual => LocalizationManager.RightLang.ConfigWindow_Param_ToggleManual,
        PluginConfigBool.UseStopCasting => LocalizationManager.RightLang.ConfigWindow_Param_UseStopCasting,

        // UI
        PluginConfigBool.UseOverlayWindow => LocalizationManager.RightLang.ConfigWindow_Param_UseOverlayWindow,
        PluginConfigBool.TeachingMode => LocalizationManager.RightLang.ConfigWindow_Param_TeachingMode,
        PluginConfigBool.ShowMoveTarget => LocalizationManager.RightLang.ConfigWindow_Param_MovingTargetColor,
        PluginConfigBool.ShowTarget => LocalizationManager.RightLang.ConfigWindow_Param_ShowTarget,
        PluginConfigBool.DrawPositional => LocalizationManager.RightLang.ConfigWindow_Param_DrawPositional,
        PluginConfigBool.DrawMeleeOffset => LocalizationManager.RightLang.ConfigWindow_Param_DrawMeleeOffset,
        PluginConfigBool.KeyBoardNoise => LocalizationManager.RightLang.ConfigWindow_Param_KeyBoardNoise,
        PluginConfigBool.ShowInfoOnDtr => LocalizationManager.RightLang.ConfigWindow_Param_ShowInfoOnDtr,
        PluginConfigBool.ShowInfoOnToast => LocalizationManager.RightLang.ConfigWindow_Param_ShowInfoOnToast,
        PluginConfigBool.ShowToastsAboutDoAction => LocalizationManager.RightLang.ConfigWindow_Param_ShowToastsAboutDoAction,
        PluginConfigBool.OnlyShowWithHostileOrInDuty => LocalizationManager.RightLang.ConfigWindow_Control_OnlyShowWithHostileOrInDuty,
        PluginConfigBool.ShowNextActionWindow => LocalizationManager.RightLang.ConfigWindow_Control_ShowNextActionWindow,
        PluginConfigBool.ShowCooldownWindow => LocalizationManager.RightLang.ConfigWindow_Control_ShowCooldownWindow,
        PluginConfigBool.IsInfoWindowNoInputs => LocalizationManager.RightLang.ConfigWindow_Control_IsInfoWindowNoInputs,
        PluginConfigBool.IsInfoWindowNoMove => LocalizationManager.RightLang.ConfigWindow_Control_IsInfoWindowNoMove,
        PluginConfigBool.ShowItemsCooldown => LocalizationManager.RightLang.ConfigWindow_Control_ShowItemsCooldown,
        PluginConfigBool.ShowGCDCooldown => LocalizationManager.RightLang.ConfigWindow_Control_ShowGCDCooldown,
        PluginConfigBool.UseOriginalCooldown => LocalizationManager.RightLang.ConfigWindow_Control_UseOriginalCooldown,
        PluginConfigBool.ShowControlWindow => LocalizationManager.RightLang.ConfigWindow_Control_ShowControlWindow,
        PluginConfigBool.IsControlWindowLock => LocalizationManager.RightLang.ConfigWindow_Control_IsInfoWindowNoMove,

        // auto
        PluginConfigBool.UseAOEAction => LocalizationManager.RightLang.ConfigWindow_Param_UseAOEAction,
        PluginConfigBool.UseAOEWhenManual => LocalizationManager.RightLang.ConfigWindow_Param_UseAOEWhenManual,
        PluginConfigBool.NoNewHostiles => LocalizationManager.RightLang.ConfigWindow_Param_NoNewHostiles,
        PluginConfigBool.PreventActions => LocalizationManager.RightLang.ConfigWindow_Param_PreventActionsIfOutOfCombat,
        PluginConfigBool.PreventActionsDuty => LocalizationManager.RightLang.ConfigWindow_Param_PreventActionsIfDutyRing,
        PluginConfigBool.AutoBurst => LocalizationManager.RightLang.ConfigWindow_Param_AutoBurst,
        PluginConfigBool.AutoHeal => LocalizationManager.RightLang.ConfigWindow_Param_AutoHeal,
        PluginConfigBool.UseTinctures => LocalizationManager.RightLang.ConfigWindow_Param_UseTinctures,
        PluginConfigBool.UseHealPotions => LocalizationManager.RightLang.ConfigWindow_Param_UseHealPotions,
        PluginConfigBool.UseAbility => LocalizationManager.RightLang.ConfigWindow_Param_UseAbility,
        PluginConfigBool.UseDefenseAbility => LocalizationManager.RightLang.ConfigWindow_Param_UseDefenseAbility,
        PluginConfigBool.AutoTankStance => LocalizationManager.RightLang.ConfigWindow_Param_AutoShield,
        PluginConfigBool.AutoProvokeForTank => LocalizationManager.RightLang.ConfigWindow_Param_AutoProvokeForTank,
        PluginConfigBool.AutoUseTrueNorth => LocalizationManager.RightLang.ConfigWindow_Param_AutoUseTrueNorth,
        PluginConfigBool.RaisePlayerBySwift => LocalizationManager.RightLang.ConfigWindow_Param_RaisePlayerBySwift,
        PluginConfigBool.AutoSpeedOutOfCombat => LocalizationManager.RightLang.ConfigWindow_Param_AutoSpeedOutOfCombat,
        PluginConfigBool.UseGroundBeneficialAbility => LocalizationManager.RightLang.ConfigWindow_Param_UseGroundBeneficialAbility,
        PluginConfigBool.RaisePlayerByCasting => LocalizationManager.RightLang.ConfigWindow_Param_RaisePlayerByCasting,
        PluginConfigBool.UseHealWhenNotAHealer => LocalizationManager.RightLang.ConfigWindow_Param_UseHealWhenNotAHealer,
        PluginConfigBool.InterruptibleMoreCheck => LocalizationManager.RightLang.ConfigWindow_Param_InterruptibleMoreCheck,
        PluginConfigBool.EsunaAll => LocalizationManager.RightLang.ConfigWindow_Param_EsunaAll,
        PluginConfigBool.HealOutOfCombat => LocalizationManager.RightLang.ConfigWindow_Param_HealOutOfCombat,
        PluginConfigBool.OnlyHotOnTanks => LocalizationManager.RightLang.ConfigWindow_Param_OnlyHotOnTanks,
        PluginConfigBool.BeneficialAreaOnTarget => LocalizationManager.RightLang.ConfigWindow_Param_BeneficialAreaOnTarget,

        // target
        PluginConfigBool.AddEnemyListToHostile => LocalizationManager.RightLang.ConfigWindow_Param_AddEnemyListToHostile,
        PluginConfigBool.ChooseAttackMark => LocalizationManager.RightLang.ConfigWindow_Param_ChooseAttackMark,
        PluginConfigBool.CanAttackMarkAOE => LocalizationManager.RightLang.ConfigWindow_Param_CanAttackMarkAOE,
        PluginConfigBool.FilterStopMark => LocalizationManager.RightLang.ConfigWindow_Param_FilterStopMark,
        PluginConfigBool.ChangeTargetForFate => LocalizationManager.RightLang.ConfigWindow_Param_ChangeTargetForFate,
        PluginConfigBool.OnlyAttackInView => LocalizationManager.RightLang.ConfigWindow_Param_OnlyAttackInView,
        PluginConfigBool.MoveTowardsScreenCenter => LocalizationManager.RightLang.ConfigWindow_Param_MoveTowardsScreen,
        PluginConfigBool.TargetAllForFriendly => LocalizationManager.RightLang.ConfigWindow_Param_ActionTargetFriendly,
        PluginConfigBool.RaiseAll => LocalizationManager.RightLang.ConfigWindow_Param_RaiseAll,
        PluginConfigBool.RaiseBrinkOfDeath => LocalizationManager.RightLang.ConfigWindow_Param_RaiseBrinkOfDeath,
        PluginConfigBool.TargetFriendly => LocalizationManager.RightLang.ConfigWindow_Param_TargetFriendly,
        PluginConfigBool.TargetFatePriority => LocalizationManager.RightLang.ConfigWindow_Param_TargetFatePriority,
        PluginConfigBool.TargetHuntingRelicLevePriority => LocalizationManager.RightLang.ConfigWindow_Param_TargetHuntingRelicLevePriority,
        PluginConfigBool.TargetQuestPriority => LocalizationManager.RightLang.ConfigWindow_Param_TargetQuestPriority,


        // extra
        PluginConfigBool.SayOutStateChanged => LocalizationManager.RightLang.ConfigWindow_Param_SayOutStateChanged,
        PluginConfigBool.PoslockCasting => LocalizationManager.RightLang.ConfigWindow_Param_PoslockCasting,
        PluginConfigBool.ShowHealthRatio => LocalizationManager.RightLang.ConfigWindow_Param_ShowHealthRatio,
        PluginConfigBool.ShowTooltips => LocalizationManager.RightLang.ConfigWindow_Param_ShowTooltips,
        PluginConfigBool.InDebug => LocalizationManager.RightLang.ConfigWindow_Param_InDebug,

        _ => string.Empty,
    };

    public static string ToName(this PluginConfigFloat config) => config switch
    {
        // basic
        PluginConfigFloat.ActionAhead => LocalizationManager.RightLang.ConfigWindow_Param_ActionAhead,
        PluginConfigFloat.MinLastAbilityAdvanced => LocalizationManager.RightLang.ConfigWindow_Param_MinLastAbilityAdvanced,
        PluginConfigFloat.CountDownAhead => LocalizationManager.RightLang.ConfigWindow_Param_CountDownAhead,
        PluginConfigFloat.SpecialDuration => LocalizationManager.RightLang.ConfigWindow_Param_SpecialDuration,
        PluginConfigFloat.MaxPing => LocalizationManager.RightLang.ConfigWindow_Param_MaxPing,
        PluginConfigFloat.AutoOffAfterCombat => LocalizationManager.RightLang.ConfigWindow_Param_AutoOffAfterCombat,
        PluginConfigFloat.WeaponDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_WeaponDelay,
        PluginConfigFloat.HostileDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_HostileDelay,
        PluginConfigFloat.InterruptDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_InterruptDelay,
        PluginConfigFloat.DeathDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_DeathDelay,
        PluginConfigFloat.WeakenDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_WeakenDelay,
        PluginConfigFloat.HealDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_HealDelay,
        PluginConfigFloat.CountdownDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_CountdownDelay,
        PluginConfigFloat.NotInCombatDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_NotInCombatDelay,
        PluginConfigFloat.ClickingDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_ClickingDelay,
        PluginConfigFloat.StopCastingDelayMin => LocalizationManager.RightLang.ConfigWindow_Param_StopCastingDelay,
        PluginConfigFloat.MistakeRatio => LocalizationManager.RightLang.ConfigWindow_Param_ClickMistake,

        // UI
        PluginConfigFloat.TargetIconSize => LocalizationManager.RightLang.ConfigWindow_Param_TargetIconSize,
        PluginConfigFloat.DrawingHeight => LocalizationManager.RightLang.ConfigWindow_Param_DrawingHeight,
        PluginConfigFloat.SampleLength => LocalizationManager.RightLang.ConfigWindow_Param_SampleLength,
        PluginConfigFloat.CooldownFontSize => LocalizationManager.RightLang.ConfigWindow_Control_CooldownFontSize,
        PluginConfigFloat.CooldownWindowIconSize => LocalizationManager.RightLang.ConfigWindow_Control_CooldownWindowIconSize,
        PluginConfigFloat.ControlWindowGCDSize => LocalizationManager.RightLang.ConfigWindow_Control_ControlWindowGCDSize,
        PluginConfigFloat.ControlWindow0GCDSize => LocalizationManager.RightLang.ConfigWindow_Control_ControlWindow0GCDSize,
        PluginConfigFloat.ControlWindowNextSizeRatio => LocalizationManager.RightLang.ConfigWindow_Control_ControlWindowNextSizeRatio,

        // auto
        PluginConfigFloat.HealWhenNothingTodoBelow => LocalizationManager.RightLang.ConfigWindow_Param_HealWhenNothingTodoBelow,
        PluginConfigFloat.DistanceForMoving => LocalizationManager.RightLang.ConfigWindow_Param_DistanceForMoving,
        PluginConfigFloat.MeleeRangeOffset => LocalizationManager.RightLang.ConfigWindow_Param_MeleeRangeOffset,
        PluginConfigFloat.HealthDifference => LocalizationManager.RightLang.ConfigWindow_Param_HealthDifference,
        PluginConfigFloat.HealthHealerRatio => LocalizationManager.RightLang.ConfigWindow_Param_HealthHealerRatio,
        PluginConfigFloat.HealthTankRatio => LocalizationManager.RightLang.ConfigWindow_Param_HealthTankRatio,

        // extra
        PluginConfigFloat.HealthRatioBoss => LocalizationManager.RightLang.ConfigWindow_Param_HealthRatioBoss,
        PluginConfigFloat.HealthRatioDying => LocalizationManager.RightLang.ConfigWindow_Param_HealthRatioDying,
        PluginConfigFloat.HealthRatioDot => LocalizationManager.RightLang.ConfigWindow_Param_HealthRatioDot,

        _ => string.Empty,   
    };

    public static string ToName(this PluginConfigVector4 config) => config switch
    {
        PluginConfigVector4.TeachingModeColor => LocalizationManager.RightLang.ConfigWindow_Param_TeachingModeColor,
        PluginConfigVector4.MovingTargetColor => LocalizationManager.RightLang.ConfigWindow_Param_MovingTargetColor,
        PluginConfigVector4.TargetColor => LocalizationManager.RightLang.ConfigWindow_Param_TargetColor,
        PluginConfigVector4.SubTargetColor => LocalizationManager.RightLang.ConfigWindow_Param_SubTargetColor,
        PluginConfigVector4.InfoWindowBg => LocalizationManager.RightLang.ConfigWindow_Control_InfoWindowBg,
        PluginConfigVector4.ControlWindowLockBg => "锁定时控制面板背景颜色",
        PluginConfigVector4.ControlWindowUnlockBg => "未锁定时控制面板背景颜色",
        _ => string.Empty,
    };

    public static string ToDescription(this JobConfigInt config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToDescription(this JobConfigFloat config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToDescription(this PluginConfigInt config) => config switch
    {
        PluginConfigInt.MoveTargetAngle => LocalizationManager.RightLang.ConfigWindow_Param_MoveAreaActionFarthestDesc,
        _ => string.Empty,
    };

    public static string ToDescription(this PluginConfigBool config) => config switch
    {
        PluginConfigBool.UseOverlayWindow => LocalizationManager.RightLang.ConfigWindow_Param_UseOverlayWindowDesc,
        PluginConfigBool.NoNewHostiles => LocalizationManager.RightLang.ConfigWindow_Params_NoNewHostilesDesc,
        PluginConfigBool.UseDefenseAbility => LocalizationManager.RightLang.ConfigWindow_Param_UseDefenseAbilityDesc,
        PluginConfigBool.AutoProvokeForTank => LocalizationManager.RightLang.ConfigWindow_Param_AutoProvokeForTankDesc,
        PluginConfigBool.CanAttackMarkAOE => LocalizationManager.RightLang.ConfigWindow_Param_AttackMarkAOEDesc,
        PluginConfigBool.MoveTowardsScreenCenter => LocalizationManager.RightLang.ConfigWindow_Param_MoveTowardsScreenDesc,
        _ => string.Empty,
    };

    public static string ToDescription(this PluginConfigFloat config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToDescription(this PluginConfigVector4 config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToCommand(this JobConfigInt config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToCommand(this JobConfigFloat config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToCommand(this PluginConfigInt config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToCommand(this PluginConfigBool config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToCommand(this PluginConfigFloat config) => config switch
    {
        _ => string.Empty,
    };

    public static string ToCommand(this PluginConfigVector4 config) => config switch
    {
        _ => string.Empty,
    };

    public static Action ToAction(this JobConfigInt config) => config switch
    {
        _ => null,
    };

    public static Action ToAction(this JobConfigFloat config) => config switch
    {
        _ => null,
    };

    public static Action ToAction(this PluginConfigInt config) => config switch
    {
        _ => null,
    };

    public static Action ToAction(this PluginConfigBool config) => config switch
    {
        _ => null,
    };

    public static Action ToAction(this PluginConfigFloat config) => config switch
    {
        _ => null,
    };

    public static Action ToAction(this PluginConfigVector4 config) => config switch
    {
        _ => null,
    };
}
