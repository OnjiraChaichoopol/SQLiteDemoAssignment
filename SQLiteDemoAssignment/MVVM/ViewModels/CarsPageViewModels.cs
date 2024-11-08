using System;
using PropertyChanged;
using SQLiteDemoAssignment.MVVM.Models;
using System.Windows.Input;

namespace SQLiteDemoAssignment.MVVM.ViewModels;

[AddINotifyPropertyChangedInterface]
public class CarsPageViewModels
{
    public List<Cars> Cars { get; set; }
    public Cars CurrentCar { get; set; }
    public ICommand AddOrUpdateCommand { get; set; }
    public ICommand DeleteCommand { get; set; }
    public CarsPageViewModels()
    {
        this.Refresh();
        AddOrUpdateCommand = new Command(async () =>
        {
            App._carRepo.AddOrUpdate(CurrentCar);
            Console.WriteLine(App._carRepo.StatusMessage);
            this.Refresh();
        });

        DeleteCommand = new Command(async () => {
            App._carRepo.Delete(CurrentCar.ID);
            this.Refresh();
        });
    }
    private void Refresh()
    {
        CurrentCar = new Cars();

        this.Cars = App._carRepo.GetAll();
    }
}
