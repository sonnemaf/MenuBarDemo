using System;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MenuBarDemo {
    public class RelayCommand : RelayCommand<object> {

        public RelayCommand(Action executeAction) : base(o => executeAction()) {
        }

        public RelayCommand(Action executeAction, Func<bool> canExecute)
            : base(o => executeAction(), o => canExecute()) {
        }
    }


}
