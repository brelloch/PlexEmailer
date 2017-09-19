using System;
using System.Collections.Generic;
using System.Linq;

namespace PlexEmailer.Utils
{
    public class MediaTracker<T>
    {

        public Dictionary<string, List<T>> internalDictionary =
            new Dictionary<string, List<T>>();

        public void Add(string key, IEnumerable<T> value)
        {
            if (this.internalDictionary.ContainsKey(key))
            {
                List<T> list = this.internalDictionary[key];
                list.AddRange(value);

            }
            else
            {
                List<T> list = new List<T>();
                list.AddRange(value);
                this.internalDictionary.Add(key, list);
            }
        }


    }
}