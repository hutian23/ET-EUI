
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(DlgMain))]
	[EnableMethod]
	public  class DlgMainViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.RawImage E_GetImgRawImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_GetImgRawImage == null )
     			{
		    		this.m_E_GetImgRawImage = UIFindHelper.FindDeepChild<UnityEngine.UI.RawImage>(this.uiTransform.gameObject,"Anchor/E_GetImg");
     			}
     			return this.m_E_GetImgRawImage;
     		}
     	}

		public UnityEngine.UI.Button E_TestButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TestButton == null )
     			{
		    		this.m_E_TestButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"Anchor/E_Test");
     			}
     			return this.m_E_TestButton;
     		}
     	}

		public UnityEngine.UI.Image E_TestImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_E_TestImage == null )
     			{
		    		this.m_E_TestImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"Anchor/E_Test");
     			}
     			return this.m_E_TestImage;
     		}
     	}

		public UnityEngine.UI.Text ELabel_Text
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_Text == null )
     			{
		    		this.m_ELabel_Text = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"Anchor/E_Test/ELabel_");
     			}
     			return this.m_ELabel_Text;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_E_GetImgRawImage = null;
			this.m_E_TestButton = null;
			this.m_E_TestImage = null;
			this.m_ELabel_Text = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.RawImage m_E_GetImgRawImage = null;
		private UnityEngine.UI.Button m_E_TestButton = null;
		private UnityEngine.UI.Image m_E_TestImage = null;
		private UnityEngine.UI.Text m_ELabel_Text = null;
		public Transform uiTransform = null;
	}
}
