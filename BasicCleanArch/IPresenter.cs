namespace BasicCleanArch
{
    public interface IPresenter<Entity,ViewModel>
    {
        ViewModel present(Entity entity);
    }
}