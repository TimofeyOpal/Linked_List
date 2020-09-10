using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List.Model
{
    class LinkedList<T>
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }

        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(item);
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Tail != null) //если хвост не пустой то присвить хвост следующему элементу
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
        }

        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }
    }
}
