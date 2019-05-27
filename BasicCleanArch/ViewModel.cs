using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BasicCleanArch
{
    /// <summary>
    /// An abstract `ViewModel` superclass that contains an implementation of
    /// INotifyPropertyChanged.
    /// </summary>
    public abstract class ViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Should be called when a property changes.
        /// </summary>
        /// <param name="name">Optional: property name.</param>
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        #endregion
    }
}
