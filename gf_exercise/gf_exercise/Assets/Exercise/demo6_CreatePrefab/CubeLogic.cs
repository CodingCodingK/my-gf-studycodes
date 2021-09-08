using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace demo6
{
    public class CubeLogic : EntityLogic
    {
        protected CubeLogic()
        {
        }    
        
        protected override void OnShow (object userData) 
        {
            base.OnShow (userData);
            Debug.Log("显示Cube实体成功");
        }
        
        protected override void OnUpdate (float elapseSeconds, float realElapseSeconds) 
        {
            base.OnUpdate (elapseSeconds,realElapseSeconds );
            Debug.Log("Cube OnUpdate");
        }
        
    }

}
