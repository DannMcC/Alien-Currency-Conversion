//using Xunit;
//using System;

//namespace CodeChallenge
//{
//    public class ProgramTest
//    {
        
//        [Fact]
//        public void PassingTest()
//        {
//            var data = new[]
//            {
//                2, // K, number of sets
//                2, /* D */ 2, /* N */
//                2,
//                2, 0,
//                0, 5,
//                3, 3,
//                3, 5,
//                1, 1, 1,
//                3, 0, 0,
//                1, 10, 0
//            };
//            var i = 0;

//            foreach (var item in GetDataSets(data))
//            {
//                Console.WriteLine($"Data Set {++i}:");

//                Console.WriteLine(item);
//            }

//            Assert.Equal(GetDataSets[0], "Data Set 1: 1");
//            Assert.Equal(GetDataSets[1], "Data Set 2: 44");
//        }

//        //[Fact]
//        //public void FailingTest()
//        //{
//        //    Assert.Equal(());
//        //}
//    }
//}
