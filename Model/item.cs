using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List.Model
{
    public class Item<T>
    {
        private T data = default(T); //значение по умолчанию
       


        public T Data
        {
            get => data; 
            set => data = value ?? throw new ArgumentNullException(nameof(value));
            
        }  
        public Item<T> Next{ get; set; }

        public Item(T data)
        {
            Data = data;
        }
    }
}
