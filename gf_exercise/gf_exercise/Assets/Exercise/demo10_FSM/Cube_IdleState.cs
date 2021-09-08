using GameFramework.Fsm;
using UnityEngine;
using UnityEngine.AI;
using UnityGameFramework.Runtime;

namespace demo10
{
    public class Cube_IdleState : FsmState<CubeLogic>
    {

        protected override void OnEnter (IFsm<CubeLogic> fsm) {
            Debug.Log("进入站立状态");
        }
	
        protected override void OnUpdate (IFsm<CubeLogic> fsm, float elapseSeconds, float realElapseSeconds) {
            /* 按W、S或者上下方向键移动 */
            float inputVertical = Input.GetAxis ("Vertical");
            
            if (inputVertical != 0) {
                /* 移动 */
                ChangeState<Cube_WalkState>(fsm);
            }
        }
	
        protected override void OnLeave (IFsm<CubeLogic> fsm, bool isShutdown) {
            
        }
	
        protected override void OnDestroy (IFsm<CubeLogic> fsm) {
            base.OnDestroy (fsm);
        }
    }
}