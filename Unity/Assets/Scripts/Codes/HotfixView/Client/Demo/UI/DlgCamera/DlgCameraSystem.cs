using System;
using UnityEngine;
using UnityEngine.Windows;

namespace ET.Client
{
    [FriendOf(typeof (DlgCamera))]
    public static class DlgCameraSystem
    {
        public static void RegisterUIEvent(this DlgCamera self)
        {
            self.View.E_QuitButton.AddListener(self.QuitCamera);
            self.View.E_PhotoButton.AddListenerAsync(self.PhotoCor);
        }

        public static void ShowWindow(this DlgCamera self, Entity contextData = null)
        {
        }

        private static void QuitCamera(this DlgCamera self)
        {
            //取消捕捉画面
            if (self.WebCamTexture != null)
            {
                self.WebCamTexture.Stop();
            }

            self.View.E_CameraRawImage.texture = null;
            self.ClientScene().GetComponent<UIComponent>().HideWindow<DlgCamera>();
        }

        public static void Refresh(this DlgCamera self)
        {
            if (self.WebCamTexture != null)
            {
                self.WebCamTexture.Stop();
            }

            //TODO 检测有无获取设备
            WebCamDevice device = WebCamTexture.devices[0];
            string deviceName = device.name;

            self.WebCamTexture = new WebCamTexture(deviceName, 1980, 1080, 60) { wrapMode = TextureWrapMode.Clamp };
            self.View.E_CameraRawImage.texture = self.WebCamTexture;
            self.WebCamTexture.Play();
        }

        private static async ETTask PhotoCor(this DlgCamera self)
        {
            Texture2D tex = HelpUtility.TextureToTexture2D(self.View.E_CameraRawImage.texture);
            byte[] bytes = tex.EncodeToPNG();
            string path = Application.persistentDataPath + "/ScreenShoot/";
            Debug.LogWarning(path);
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            File.WriteAllBytes(path + Guid.NewGuid() + ".png", bytes);

            //刷新图片，显示到相册中
            // using (AndroidJavaClass PlayerActivity = new("com.unity3d.player.UnityPlayer"))
            // {
            //     AndroidJavaObject playerActivity = PlayerActivity.GetStatic<AndroidJavaObject>("currentActivity");
            //     using (AndroidJavaObject Conn = new ("android.media.MediaScannerConnection",playerActivity,null))
            //     {
            //         Conn.CallStatic("scanFile",playerActivity,path,null,null);
            //     }
            // }
            await ETTask.CompletedTask;
        }
    }
}