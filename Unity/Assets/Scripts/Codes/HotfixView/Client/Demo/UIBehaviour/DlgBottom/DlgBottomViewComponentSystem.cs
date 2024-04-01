
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ObjectSystem]
	public class DlgBottomViewComponentAwakeSystem : AwakeSystem<DlgBottomViewComponent> 
	{
		protected override void Awake(DlgBottomViewComponent self)
		{
			self.uiTransform = self.Parent.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgBottomViewComponentDestroySystem : DestroySystem<DlgBottomViewComponent> 
	{
		protected override void Destroy(DlgBottomViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
