using MVVMHello.DAL;
using MVVMHello.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace MVVMHello.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Properties

        private List<Customer> customers;

        public List<Customer> Customers 
        {
            get 
            {
                return customers;
            }
            set 
            {
                if (customers == value)
                {
                    return;
                }
                customers = value;
                OnPropertyChanged("Customers");
            }
        }

        #endregion

        #region Commands

        private ICommand customerCommand;

        public ICommand CustomerCommand 
        {
            get
            {
                if (customerCommand == null)
                {
                    customerCommand = new RelayCommand(param => this.CustomerCommandExecute(), null);
                }

                return customerCommand;
            }        
        }
        
        #endregion

        public MainWindowViewModel()
        {
        }

        private void CustomerCommandExecute()
        {
            var customerService = new CustomerService();

            var result = customerService.GetCustomer();

            Customers = new List<Customer>(result);
        }
    }
}
