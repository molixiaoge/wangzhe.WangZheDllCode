using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Hero_HeroWarmNormalAI_node16 : Action
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			uint objID = (uint)pAgent.GetVariable(1205869406u);
			((ObjAgent)pAgent).SelectTarget(objID);
			return EBTStatus.BT_SUCCESS;
		}
	}
}
