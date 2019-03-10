namespace BasicCleanArch
{
    public interface IDisplayer<T>
    {
        void Display(Result<T> response);         
    }
}