
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(DlgCamera))]
	[EnableMethod]
	public  class DlgCameraViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.RawImage E_CameraRawImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_CameraRawImage == null )
     			{
		    		this.m_E_CameraRawImage = UIFindHelper.FindDeepChild<UnityEngine.UI.RawImage>(this.uiTransform.gameObject,"E_Camera");
     			}
     			return this.m_E_CameraRawImage;
     		}
     	}

		public UnityEngine.UI.Button E_QuitButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_QuitButton == null )
     			{
		    		this.m_E_QuitButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Background/E_Quit");
     			}
     			return this.m_E_QuitButton;
     		}
     	}

		public UnityEngine.UI.Image E_QuitImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_QuitImage == null )
     			{
		    		this.m_E_QuitImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Background/E_Quit");
     			}
     			return this.m_E_QuitImage;
     		}
     	}

		public UnityEngine.UI.Button E_PhotoButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PhotoButton == null )
     			{
		    		this.m_E_PhotoButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Background/E_Photo");
     			}
     			return this.m_E_PhotoButton;
     		}
     	}

		public UnityEngine.UI.Image E_PhotoImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_PhotoImage == null )
     			{
		    		this.m_E_PhotoImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Background/E_Photo");
     			}
     			return this.m_E_PhotoImage;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_CameraRawImage = null;
			this.m_E_QuitButton = null;
			this.m_E_QuitImage = null;
			this.m_E_PhotoButton = null;
			this.m_E_PhotoImage = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.RawImage m_E_CameraRawImage = null;
		private UnityEngine.UI.Button m_E_QuitButton = null;
		private UnityEngine.UI.Image m_E_QuitImage = null;
		private UnityEngine.UI.Button m_E_PhotoButton = null;
		private UnityEngine.UI.Image m_E_PhotoImage = null;
		public Transform uiTransform = null;
	}
}
