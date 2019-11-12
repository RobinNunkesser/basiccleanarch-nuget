namespace BasicCleanArch
{
    /// <summary>
    /// A `UseCase` is typically implemented by an interactor.
    /// It executes the business logic of the use case.
    /// </summary>
    public interface IUseCase<in TRequest, TResponse>
    {
        /// <summary>
        /// Executes the UseCase.
        /// </summary>
        /// <param name="request">Encapsulated request parameters.</param>
        /// <param name="displayer">The Displayer to use for the result.</param>
        /// <param name="requestCode">optional requestCode to distinguish similar requests.</param>
        void Execute(TRequest request, IDisplayer<TResponse> displayer, int requestCode = 0);
    }
}