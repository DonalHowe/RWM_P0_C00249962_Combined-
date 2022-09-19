using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

namespace tests
{


    public class CombinedFilterTest : MonoBehaviour
    {

        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 1, 3, 5, 7, 9 }; // 25
            int[] output = CombinedFilter.combinedFilter(input);
            // feed into xor filter { 1, 4,9,16,25};

            int[] expected = { 20,17,28,5,12};//12

            CollectionAssert.AreEqual(expected, output);
        }


    }
}
