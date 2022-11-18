﻿using Dalamud.Interface.Components;
using Dalamud.Interface;
using ImGuiNET;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using XIVAutoAttack.Actions;
using XIVAutoAttack.Data;
using XIVAutoAttack.Windows;
using XIVAutoAttack.Combos.Script.Conditions;
using Lumina.Excel.GeneratedSheets;

namespace XIVAutoAttack.Combos.Script.Actions
{
    internal class ActionsSet : IDraw
    {
        [JsonIgnore]
        public string Name { get; set; }

        [JsonIgnore]
        public string Description { get; set; }

        private bool _openPopup = false;

        public List<ActionConditions> ActionsCondition { get; set; } = new List<ActionConditions>();

        public bool ShouldUse(IScriptCombo owner, out IAction act)
        {
            act = null;

            foreach (var condition in ActionsCondition)
            {
                var result = condition.ShouldUse(owner, out act);

                if (result.HasValue && result.Value) return true;
                else if(!result.HasValue) return false;
            }

            return false;
        }

        public void DrawHeader()
        {
            if (ImGui.Selectable(Name))
            {
                XIVAutoAttackPlugin._scriptComboWindow.ActiveSet = this;
            }
        }

        public void Draw(IScriptCombo combo)
        {
            ImGui.TextWrapped(Description);

            AddButton(combo);

            foreach (var item in ActionsCondition)
            {
                item.DrawHeader();

                ImGui.SameLine();
                ComboConfigWindow.Spacing();

                if (ImGuiComponents.IconButton(FontAwesomeIcon.Cross))
                {
                    ActionsCondition.Remove(item);
                }
            }
        }

        private void AddButton(IScriptCombo combo)
        {
            if (ImGuiComponents.IconButton(FontAwesomeIcon.Plus))
            {
                _openPopup = true;
            }

            if (_openPopup && ImGui.BeginPopup("Popup" + GetHashCode().ToString()))
            {
                if (ImGui.Selectable("守卫"))
                {
                    ActionsCondition.Add(new ActionConditions()
                    {
                        ID = ActionID.None,
                    });
                }

                foreach (var item in combo.AllActions)
                {
                    if (ImGui.Selectable(item.Name))
                    {
                        ActionsCondition.Add(new ActionConditions()
                        {
                            ID = (ActionID)item.ID,
                        });
                    }
                }
                

                ImGui.EndPopup();
            }
        }
    }
}