namespace ET.Client
{
	[Event(SceneType.Client)]
	public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override async ETTask Run(Scene scene, EventType.AppStartInitFinish args)
		{
			// scene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Login);
			await ETTask.CompletedTask;
		}
	}
}
//1. 摄像头 --- 进行中 现在需要打包测试
//2. 保存图片 和tag信息 --- 在移动端建立相册
//3. 存档信息 (日期,命名, tags)
//4. 显示所有的错题信息 --- 进阶 分页
