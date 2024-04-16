using ET.EventType;

namespace ET.Client
{
    [Event(SceneType.Client)]
    public class AppStartInitFinish_LoadUI : AEvent<AppStartInitFinish>
    {
        protected override async ETTask Run(Scene scene, AppStartInitFinish a)
        {
            await scene.GetComponent<UIComponent>().ShowWindowAsync(WindowID.WindowID_Bottom);
            await scene.GetComponent<UIComponent>().ShowWindowAsync(WindowID.WindowID_Main);
            await ETTask.CompletedTask;
        }
    }
}