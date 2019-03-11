namespace BasicCleanArch
{
    /// <summary>
    /// A `UseCase` is typically implemented by an interactor.
    /// It executes the business logic of the use case.
    /// </summary>
    public interface IUseCase<Request, Response>
    {
        /// <summary>
        /// Executes the UseCase.
        /// </summary>
        /// <param name="request">Encapsulated request parameters.</param>
        /// <param name="displayer">The Displayer to use for the result.</param>
        void Execute(Request request, IDisplayer<Response> displayer);
    }
}