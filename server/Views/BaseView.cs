namespace NMaier.SimpleDlna.Server.Views
{
  internal abstract class BaseView : IView
  {
    public abstract string Description { get; }
    public abstract string Name { get; }


    public override string ToString()
    {
      return string.Format("{0} - {1}", Name, Description);
    }

    public abstract IMediaFolder Transform(IMediaFolder root);
  }
}