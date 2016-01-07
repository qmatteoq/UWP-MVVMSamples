using System;
using Windows.Devices.Geolocation;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Threading;

namespace MVVMLight.Dispatcher.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly Geolocator _geolocator;

        public MainViewModel()
        {
            _geolocator = new Geolocator();
            _geolocator.DesiredAccuracy = PositionAccuracy.High;
            _geolocator.MovementThreshold = 50;
        }

        private string _coordinates;

        public string Coordinates
        {
            get { return _coordinates; }
            set { Set(ref _coordinates, value); }
        }

        private RelayCommand _startGeolocationCommand;

        public RelayCommand StartGeolocationCommand
        {
            get
            {
                if (_startGeolocationCommand == null)
                {
                    _startGeolocationCommand = new RelayCommand(() =>
                    {
                        _geolocator.PositionChanged += _geolocator_PositionChanged;
                    });
                }

                return _startGeolocationCommand;
            }
        }

        private async void _geolocator_PositionChanged(Geolocator sender, PositionChangedEventArgs args)
        {
            await DispatcherHelper.RunAsync(() =>
            {
                Coordinates =
                    $"{args.Position.Coordinate.Point.Position.Latitude}, {args.Position.Coordinate.Point.Position.Longitude}";
            });
        }
    }
}
