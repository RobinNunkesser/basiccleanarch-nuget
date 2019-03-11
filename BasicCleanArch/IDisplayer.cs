namespace BasicCleanArch
{
    /// <summary>
    /// A Displayer is used to display the result of a use case that changes the
    /// displayed view.
    /// </summary>
    public interface IDisplayer<T>
    {
        /// <summary>
        /// Display the specified result.
        /// </summary>
        /// <param name="result">The Result to display.</param>
        void Display(Result<T> result);         
    }
}