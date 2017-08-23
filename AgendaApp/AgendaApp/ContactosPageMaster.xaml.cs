﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactosPageMaster : ContentPage
	{
		public ListView ListView;

		public ContactosPageMaster()
		{
			InitializeComponent();

			BindingContext = new ContactosPageMasterViewModel();
			ListView = MenuItemsListView;
		}

		class ContactosPageMasterViewModel : INotifyPropertyChanged
		{
			public ObservableCollection<ContactosPageMenuItem> MenuItems { get; set; }

			public ContactosPageMasterViewModel()
			{
				MenuItems = new ObservableCollection<ContactosPageMenuItem>(new[]
				{
					new ContactosPageMenuItem { Id = 0, Title = "Page 1" },
					new ContactosPageMenuItem { Id = 1, Title = "Page 2" },
					new ContactosPageMenuItem { Id = 2, Title = "Page 3" },
					new ContactosPageMenuItem { Id = 3, Title = "Page 4" },
					new ContactosPageMenuItem { Id = 4, Title = "Page 5" },
				});
			}

			#region INotifyPropertyChanged Implementation
			public event PropertyChangedEventHandler PropertyChanged;
			void OnPropertyChanged([CallerMemberName] string propertyName = "")
			{
				if (PropertyChanged == null)
					return;

				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
			#endregion
		}
	}
}