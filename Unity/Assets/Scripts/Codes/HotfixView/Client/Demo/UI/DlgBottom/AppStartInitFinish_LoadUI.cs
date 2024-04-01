using ET.EventType;

namespace ET.Client
{
    [Event(SceneType.Client)]
    public class AppStartInitFinish_LoadUI : AEvent<AppStartInitFinish>
    {
        protected override async ETTask Run(Scene scene, AppStartInitFinish a)
        {
            scene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Bottom);
            await ETTask.CompletedTask;
        }
    }
}