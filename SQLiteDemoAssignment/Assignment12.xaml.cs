using System.Security.Cryptography.X509Certificates;
using SQLiteDemoAssignment.MVVM.ViewModels;

namespace SQLiteDemoAssignment;

public partial class Assignment12 : ContentPage
{
	public Assignment12()
	{
		InitializeComponent();
		BindingContext = new CarsPageViewModels();

	}
}