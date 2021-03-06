﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HPSWidgetViewModel.cs" company="SyndicatedLife">
//   Copyright© 2007 - 2021 Ryan Wilson &amp;lt;syndicated.life@gmail.com&amp;gt; (https://syndicated.life/)
//   Licensed under the MIT license. See LICENSE.md in the solution root for full license information.
// </copyright>
// <summary>
//   HPSWidgetViewModel.cs Implementation
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FFXIVAPP.Plugin.Parse.Windows {
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using FFXIVAPP.Plugin.Parse.Models;

    internal sealed class HPSWidgetViewModel : INotifyPropertyChanged {
        private static Lazy<HPSWidgetViewModel> _instance = new Lazy<HPSWidgetViewModel>(() => new HPSWidgetViewModel());

        private ParseEntity _parseEntity;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public static HPSWidgetViewModel Instance {
            get {
                return _instance.Value;
            }
        }

        public ParseEntity ParseEntity {
            get {
                return this._parseEntity ?? (this._parseEntity = new ParseEntity());
            }

            set {
                this._parseEntity = value;
                this.RaisePropertyChanged();
            }
        }

        private void RaisePropertyChanged([CallerMemberName] string caller = "") {
            this.PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }
    }
}