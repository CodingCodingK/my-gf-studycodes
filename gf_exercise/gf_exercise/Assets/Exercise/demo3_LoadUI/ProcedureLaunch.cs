using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;

namespace demo3
{
    public class ProcedureLaunch : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {

            base.OnEnter(procedureOwner);

            SceneComponent scene = UnityGameFramework.Runtime.GameEntry.GetComponent<SceneComponent>();

            // 切换场景
            scene.LoadScene("Assets/Exercise/demo3_LoadUI/demo3_Menu.unity", this);

            // 切换流程
            ChangeState<ProcedureMenu>(procedureOwner);

        }
    }
}