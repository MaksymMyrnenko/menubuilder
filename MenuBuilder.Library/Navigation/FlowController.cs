﻿namespace MenuBuilder.Library.Navigation
{
    public class FlowController
    {
        private readonly Stack<IMenu> _menuStack = new Stack<IMenu>();

        public IMenu CurrentMenu => _menuStack.Peek();

        public void NavigateTo(IMenu menu)
        {
            _menuStack.Push(menu);
        }

        public void NavigateBack()
        {
            if (_menuStack.Count > 1)
            {
                _menuStack.Pop();
            }
            else
            {
                Console.WriteLine("No previous menu to navigate back to.");
            }
        }
    }
}
