﻿using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BasicCleanArch
{
    /// <summary>
    ///     Convenience `ViewModel` for Group bindings in ListViews.
    /// </summary>
    public class SectionViewModel<T> : ObservableCollection<T>
    {
        private string _longName;
        private string _shortName;

        public string LongName
        {
            get => _longName;
            set
            {
                if (_longName != value)
                {
                    _longName = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("LongName"));
                }
            }
        }

        public string ShortName
        {
            get => _shortName;
            set
            {
                if (_shortName != value)
                {
                    _shortName = value;
                    OnPropertyChanged(
                        new PropertyChangedEventArgs("ShortName"));
                }
            }
        }
    }
}