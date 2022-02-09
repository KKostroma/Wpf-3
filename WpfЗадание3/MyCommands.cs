using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfЗадание3
{
    internal class MyCommands
    {
        public static RoutedCommand Close { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs=new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Cntrl+T"));
            Close = new RoutedCommand("Close",typeof(MyCommands),inputs);
        }
    }
}
