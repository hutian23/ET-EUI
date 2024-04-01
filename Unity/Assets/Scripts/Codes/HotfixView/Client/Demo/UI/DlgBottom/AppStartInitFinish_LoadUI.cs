using ET.EventType;

namespace ET.Client
{
    [Event(SceneType.Client)]
    public class AppStartInitFinish_LoadUI : AEvent<AppStartInitFinish>
    {
        protected override ETTask Run(Scene scene, AppStartInitFinish a)
        {
            throw new System.NotImplementedException();
        }
    }
}