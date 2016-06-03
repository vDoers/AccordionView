using AccordianView.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AccordianView.Pages
{
	public partial class AccordianPage : ContentPage
	{
		public AccordianPage ()
		{
			InitializeComponent ();
            BindingContext = new AccordianViewModel();
		}
	}
}
