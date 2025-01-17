﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GGYSTOREe
{
    public class RelayCommand(Action<object>execute,Func<object,bool>?canExecute=null) : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)=>
        
            canExecute==null|| this.CanExecute(parameter);
        

        public void Execute(object? parameter)=>
        
            this.Execute(parameter);
        
    }
}
