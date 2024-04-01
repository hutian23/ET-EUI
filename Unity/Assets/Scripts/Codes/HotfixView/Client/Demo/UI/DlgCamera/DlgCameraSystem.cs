using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
    [FriendOf(typeof (DlgCamera))]
    public static class DlgCameraSystem
    {
        public static void RegisterUIEvent(this DlgCamera self)
        {
            self.View.E_QuitButton.AddListener(self.QuitCamera);
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

            self.WebCamTexture = new WebCamTexture(deviceName, Screen.width,Screen.height, 60)
            {
                wrapMode = TextureWrapMode.Repeat
            };

            AspectRatioFitter fit = self.View.E_CameraRawImage.GetComponent<AspectRatioFitter>();
            fit.aspectRatio = (float)self.WebCamTexture.width / self.WebCamTexture.height;
            self.View.E_CameraRawImage.texture = self.WebCamTexture;
            self.WebCamTexture.Play();
        }
    }
}