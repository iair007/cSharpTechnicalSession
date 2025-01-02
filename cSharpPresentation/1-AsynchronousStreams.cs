using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharpPresentation
{
    internal static class AsynchronousStreams
    {
        #region oldway
        public static async Task Run()
        {
            var myList = await GenerateSequenceWithoutIAsyncEnumerable();
            foreach (var number in myList)
            {
                Console.WriteLine(number);
            }
        }
        public static async Task<List<int>> GenerateSequenceWithoutIAsyncEnumerable()
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                myList.Add(i);
            }
            return myList;
        }

        #endregion

        #region AsynchronousStreams
        public static async Task RunAsync()
        {
            await foreach (var number in GenerateSequence())
            {
                Console.WriteLine(number);
            }
        }

        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
        #endregion
    }
}
