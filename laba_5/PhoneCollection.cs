using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal class PhoneCollection : IEnumerable<IPhone>, IEnumerator<IPhone>
    {
        private List<IPhone> phones = new List<IPhone>();
        private int position = -1;

        public void Add(IPhone phone)
        {
            phones.Add(phone);
        }

        public void SortByCores()
        {
            phones.Sort((x, y) => x.Cores.CompareTo(y.Cores));
        }

        public IPhone Current => phones[position];

        object IEnumerator.Current => Current;

        public IEnumerator<IPhone> GetEnumerator()
        {
            position = -1;
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            position++;
            return position < phones.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            // нічого не потрібно
        }
    }
}
