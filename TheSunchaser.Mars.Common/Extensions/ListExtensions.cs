using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSunchaser.Mars.Common.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Returns an IEnumerable that is a sub list of the initial list based on the nSize specified
        /// </summary>
        /// <typeparam name="T">Type of List</typeparam>
        /// <param name="list">List of T to split</param>
        /// <param name="nSize">Size of the sub list</param>
        /// <returns></returns>
        public static IEnumerable<List<T>> SplitList<T>(this List<T> list, int nSize)
        {
            for (int i = 0; i < list.Count; i += nSize)
            {
                yield return list.GetRange(i, Math.Min(nSize, list.Count - i));
            }
        }

        /// <summary>
        /// Returns an IEnumerable that is a sub list of the initial list based on the nSize specified
        /// </summary>
        /// <typeparam name="T">Type of List</typeparam>
        /// <param name="list">List of T to split</param>
        /// <param name="nSize">Size of the sub list</param>
        /// <param name="startIndex">The starting index to split the list from. E.g 1 = skip 1st item</param>
        /// <returns></returns>
        public static IEnumerable<List<T>> SplitList<T>(this List<T> list, int nSize, int startIndex)
        {
            for (int i = startIndex; i < list.Count; i += nSize)
            {
                yield return list.GetRange(i, Math.Min(nSize, list.Count - i));
            }
        }
    }
}
