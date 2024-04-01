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
			await Application.RequestUserAuthorization(UserAuthorization.WebCam);
			if (!Application.HasUserAuthorization(UserAuthorization.WebCam))
			{
				Log.Warning("没有权限!!");	
				return;
			}
			Log.Warning("权限通过");
			await self.ClientScene().GetComponent<UIComponent>().ShowWindowAsync<DlgCamera>();
			self.ClientScene().GetComponent<UIComponent>().GetDlgLogic<DlgCamera>().Refresh();
			await ETTask.CompletedTask;
		}
	}
}
