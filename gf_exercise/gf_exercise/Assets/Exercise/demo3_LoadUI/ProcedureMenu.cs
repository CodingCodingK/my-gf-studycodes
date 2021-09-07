using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace demo3
{
    public class ProcedureMenu : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {

            base.OnEnter(procedureOwner);

            // 加载框架UI组件
            UIComponent UI = UnityGameFramework.Runtime.GameEntry.GetComponent<UIComponent>();

            // 加载UI
            UI.OpenUIForm("Assets/Exercise/demo3_LoadUI/UI_Menu.prefab", "DefaultGroup");

        }
    }
}