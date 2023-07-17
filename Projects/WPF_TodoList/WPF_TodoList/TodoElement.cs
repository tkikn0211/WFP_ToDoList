using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList
{
    class TodoElement
    {
        public TodoElement(string Element, bool DoneFlg)
        {
            this.Element = Element;
            this.DoneFlg = DoneFlg;
        }
        public string Element { get; set; }
        public bool DoneFlg { get; set; }
    }
}