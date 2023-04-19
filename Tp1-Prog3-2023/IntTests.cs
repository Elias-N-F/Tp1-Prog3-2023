using System.Diagnostics;


namespace Tp1_Prog3_2023
{
    public class IntTests
    {

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestAddIntLL(int cantidad)
        { 
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < cantidad; i++) { 
                list.AddLast(i);
            }
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestAddIntList(int cantidad)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < cantidad; i++)
            {
                list.Add(i);
            }
        }


        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestInsertIntLL(int cantidad)
        {
            //Agrega cantidad, inserta cantidad despues del primer indice

            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < cantidad; i++)
            {
                list.AddLast(i);
               
            }

            for (int i = cantidad; i < cantidad*2; i++)
            {
                list.AddBefore(list.First, i);
            }

        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        //[InlineData(1000000)] > 1 minuto
        //[InlineData(10000000)]
        public void TestInsertIntList(int cantidad)
        {
            //Agrega cantidad, inserta cantidad despues del primer indice

            List<int> list = new List<int>();
            for (int i = 0; i < cantidad; i++)
            {
                list.Add(i);
            }

           
            for (int i = cantidad ; i < cantidad*2; i++) {
               
                list.Insert(1 ,i);
            }

        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestAddAndRemoveIntLL(int cantidad)
        {
            //Agrega cantidad, despues la elimina uno por uno

            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < cantidad; i++)
            {
                list.AddLast(i);

            }
            
            while (list.Count > 0) { list.RemoveFirst(); }
            
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        //[InlineData(1000000)] > 2 minutos
        //[InlineData(10000000)]
        public void TestAddAndRemoveIntList(int cantidad)
        {
            //Agrega cantidad, despues la elimina uno por uno

            List<int> list = new List<int>();
            for (int i = 0; i < cantidad; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
               
                list.RemoveAt(i);
            }

        }

    }
}