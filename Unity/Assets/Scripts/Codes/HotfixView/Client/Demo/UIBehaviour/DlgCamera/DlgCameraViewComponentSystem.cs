
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ObjectSystem]
	public class DlgCameraViewComponentAwakeSystem : AwakeSystem<DlgCameraViewComponent> 
	{
		protected override void Awake(DlgCameraViewComponent self)
		{
			self.uiTransform = self.Parent.GetParent<UIBaseWindow>().uiTransform;
		}
	}


	[ObjectSystem]
	public class DlgCameraViewComponentDestroySystem : DestroySystem<DlgCameraViewComponent> 
	{
		protected override void Destroy(DlgCameraViewComponent self)
		{
			self.DestroyWidget();
		}
	}
}
