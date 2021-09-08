using GameFramework.Fsm;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace demo10
{
    public class CubeLogic : EntityLogic
    {
        private FsmComponent Fsm;

        private IFsm<CubeLogic> cubeFsm;
        
        protected CubeLogic()
        {
        }    
        
        protected override void OnShow (object userData) 
        {
            base.OnShow (userData);
            Debug.Log("显示Cube实体成功");
        }
        
        protected override void OnInit (object userData) 
        {
            base.OnInit(userData);
            Fsm = UnityGameFramework.Runtime.GameEntry.GetComponent<FsmComponent>();

            FsmState<CubeLogic>[] cubeStates = new FsmState<CubeLogic>[]
            {
                new Cube_IdleState(),
                new Cube_WalkState()
            };
            
            // 创建状态机
            cubeFsm = Fsm.CreateFsm<CubeLogic>(this, cubeStates);
            
            // 启动状态机
            cubeFsm.Start<Cube_IdleState>();
        }
        
    }
}