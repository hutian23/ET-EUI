namespace ET.Client
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgBottom :Entity,IAwake,IUILogic
	{

		public DlgBottomViewComponent View { get => this.GetComponent<DlgBottomViewComponent>();} 
	}
}
