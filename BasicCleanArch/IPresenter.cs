namespace BasicCleanArch
{
    /// <summary>
    /// A Presenter is used to get a ViewModel from Entities or other Models.
    /// </summary>
    public interface IPresenter<Model,ViewModel>
    {
        /// <summary>
        /// Present the specified model.
        /// </summary>
        /// <returns>The ViewModel.</returns>
        /// <param name="model">The model to present.</param>
        ViewModel present(Model model);
    }
}