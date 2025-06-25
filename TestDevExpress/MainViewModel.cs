using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace TestDevExpress
{
    internal class MainViewModel : ObservableObject
    {


        public ObservableCollection<Star> Stars { get; set; }


        private ObservableCollection<Star> collection1 =
            [
            new Star(1, 1, 1,1),
            new Star(2, 2, 2, 2),
            new Star(3, 3, 3, 3),
            new Star(4, 4, 4,4),
            ];
        private ObservableCollection<Star> collection2 =
             [
            new Star(1, 1, 1,4),
            new Star(2, 2, 1,4),
            new Star(3, 3, 1,4),
            new Star(4, 4, 1,4),
            ];

        public MainViewModel()
        {
            Stars = collection1;
            SwitchCollectionCommand = new RelayCommand(SwitchCollection);
        }

        public RelayCommand SwitchCollectionCommand { get; }

        public void SwitchCollection()
        {
            Stars = (Stars == collection1) ? collection2 : collection1;
            OnPropertyChanged(nameof(Stars));
        }
    }

    public class Star
    {
        public double ColorIndex { get; private set; }
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Star(
                double x,
                double y,
                double z,
                double colorIndex
        )
        {
            X = x;
            Y = y;
            Z = z;
            ColorIndex = colorIndex;
        }
    }


}
