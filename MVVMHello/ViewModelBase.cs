using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMHello
{
    public abstract class ViewModelBase : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanging([CallerMemberName] string propetyName = "") 
        {
            PropertyChanging(this, new PropertyChangingEventArgs(propetyName));
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "") 
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
