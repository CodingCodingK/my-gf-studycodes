using GameFramework;
using GameFramework.Event;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace demo7
{
    public class ProcedureLaunch : ProcedureBase {
        
        protected override void OnEnter (IFsm<IProcedureManager> procedureOwner)
        {

            base.OnEnter(procedureOwner);
                
            // 获取框架事件组件
            EventComponent Event = UnityGameFramework.Runtime.GameEntry.GetComponent<EventComponent> ();
            Event.Subscribe (WebRequestSuccessEventArgs.EventId, OnWebRequestSuccess);
            Event.Subscribe (WebRequestFailureEventArgs.EventId, OnWebRequestFailure);
            
            // 获取框架网络组件
            WebRequestComponent WebRequest = UnityGameFramework.Runtime.GameEntry.GetComponent<WebRequestComponent> ();
            string url = "http://www.benmutou.com/archives/2603";
            WebRequest.AddWebRequest (url, this);
            
        }
        
        private void OnWebRequestSuccess (object sender, GameEventArgs e) {
            WebRequestSuccessEventArgs ne = (WebRequestSuccessEventArgs) e;
            // 获取回应的数据
            string responseJson = Utility.Converter.GetString (ne.GetWebResponseBytes ());
            Debug.Log("responseJson：" + responseJson);
        }
        
        private void OnWebRequestFailure (object sender, GameEventArgs e) {
            Debug.LogWarning("请求失败");
        }
    }
}