using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
	[FriendOf(typeof(DlgBottom))]
	public static  class DlgBottomSystem
	{

		public static void RegisterUIEvent(this DlgBottom self)
		{
			self.View.E_CameraButton.AddListenerAsync(self.TakePhotoCor);
		}

		public static void ShowWindow(this DlgBottom self, Entity contextData = null)
		{
		}

		private static async ETTask TakePhotoCor(this DlgBottom self)
		{
			// self.ClientScene().GetComponent<UIComponent>().GetDlgLogic<>()
			await Application.RequestUserAuthorization(UserAuthorization.WebCam);
			//没有权限
			if (!Application.HasUserAuthorization(UserAuthorization.WebCam))
			{
				//TODO 
			}

			WebCamDevice[] devices = WebCamTexture.devices;
			if (WebCamTexture.devices.Length <= 0)
			{
				Log.Error("没有摄像头，请检查");
			}
			else
			{
				string deviceName = devices[0].name;
				//获取size
				RawImage raw;
				// WebCamTexture webCamTexture = new WebCamTexture(deviceNam);
			}
			
			
			await ETTask.CompletedTask;
		}
	}
}
