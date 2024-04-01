
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(DlgBottom))]
	[EnableMethod]
	public  class DlgBottomViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Button E_CameraButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CameraButton == null )
     			{
		    		this.m_E_CameraButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"E_Camera");
     			}
     			return this.m_E_CameraButton;
     		}
     	}

		public UnityEngine.UI.Image E_CameraImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CameraImage == null )
     			{
		    		this.m_E_CameraImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"E_Camera");
     			}
     			return this.m_E_CameraImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_CameraButton = null;
			this.m_E_CameraImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Button m_E_CameraButton = null;
		private UnityEngine.UI.Image m_E_CameraImage = null;
		public Transform uiTransform = null;
	}
}
