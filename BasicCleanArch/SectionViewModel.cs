using System.Collections.ObjectModel;

namespace BasicCleanArch
{
    /// <summary>
    /// Covenience `ViewModel` for Group bindings in ListViews.
    /// </summary>
    public class SectionViewModel<T> : ObservableCollection<T>
    { 
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}
