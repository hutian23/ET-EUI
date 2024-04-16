using UnityEngine;
using UnityEngine.Windows;

namespace ET.Client
{
	[FriendOf(typeof(DlgMain))]
	public static  class DlgMainSystem
	{

		public static void RegisterUIEvent(this DlgMain self)
		{
			self.View.E_TestButton.AddListenerAsync(self.LoadImgCor);
		}

		public static void ShowWindow(this DlgMain self, Entity contextData = null)
		{
		}

		private static async ETTask LoadImgCor(this DlgMain self)
		{
			string path = Application.persistentDataPath + "/ScreenShoot/";
			byte[] bytes = File.ReadAllBytes(path + "4ab633f3-3765-4465-bd70-19704ef0dced.png");

			Texture2D texture2D = new Texture2D(1500, 1000);
			texture2D.LoadImage(bytes);
			self.View.E_GetImgRawImage.texture = texture2D;
			
			await ETTask.CompletedTask;
		}
	}
}
