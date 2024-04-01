using UnityEngine;

namespace ET.Client
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgCamera :Entity,IAwake,IUILogic
	{
		public DlgCameraViewComponent View { get => this.GetComponent<DlgCameraViewComponent>();}

		public WebCamTexture WebCamTexture;
	}
}
