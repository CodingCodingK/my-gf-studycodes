using GameFramework.Fsm;
using UnityEngine;

namespace demo10
{
    public class Cube_WalkState : FsmState<CubeLogic>
    {

        protected override void OnEnter (IFsm<CubeLogic> fsm) {
            Debug.Log("进入移动状态");
        }
	
        protected override void OnUpdate (IFsm<CubeLogic> fsm, float elapseSeconds, float realElapseSeconds) {
            /* 按W、S或者上下方向键移动 */
            float inputVertical = Input.GetAxis ("Vertical");
            
            if (inputVertical != 0) {
                /* 移动 */
                fsm.Owner.transform.position += new Vector3(0,inputVertical * elapseSeconds,0);
            }
            else
            {
                /* 站立 */
                ChangeState<Cube_IdleState>(fsm);
            }
        }
	
        protected override void OnLeave (IFsm<CubeLogic> fsm, bool isShutdown) {
            
        }
        
    }
}