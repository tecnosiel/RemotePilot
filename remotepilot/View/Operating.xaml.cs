using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RemotePilot
{
    public partial class Operating : ContentPage
    {
        public Operating()
        {
            InitializeComponent();

            // The TapViewModel contains the TapCommand which is wired up in Xaml
            BindingContext = new TapViewModel();

        }


    }
}
