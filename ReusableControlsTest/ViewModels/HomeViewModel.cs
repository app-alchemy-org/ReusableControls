using ReusableControlsTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableControlsTest.ViewModels
{
    internal class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            DeviceList = new ObservableCollection<DeviceModel>
            {
                new DeviceModel
                {
                    Title = "Living Room",
                    Name = "Sammy",
                    Status = "Offline",
                    IconUri = "tv.png"
                },
                new DeviceModel
                {
                    Title = "Bedroom 1",
                    Name = "Aircon",
                    Status = "Off",
                    IconUri = "aircon.png"
                }
            };
        }

        private ObservableCollection<DeviceModel> _deviceList = [];
        public ObservableCollection<DeviceModel> DeviceList
        {
            get => _deviceList;
            set
            {
                if (_deviceList != value)
                {
                    _deviceList = value;
                    OnPropertyChanged(nameof(DeviceList));
                }
            }
        }
    }
}
