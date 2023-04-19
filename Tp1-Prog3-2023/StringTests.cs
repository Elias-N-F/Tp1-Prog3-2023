using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Prog3_2023
{
    public class StringTests
    {

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestAddStringLL(int cantidad)
        {
            LinkedList<string> list = new();
            

            for (int i = 0; i < cantidad; i++)
            {
                string p = "Esto es una string";
                list.AddLast(p);
            }
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestAddStringList(int cantidad)
        {
            List<string> list = new();
            for (int i = 0; i < cantidad; i++)
            {
                string p = "Esto es una string";
                list.Add(p);
            }
        }


        [Theory]
        [InlineData(500)]
        [InlineData(5000)]
        [InlineData(50000)]
        [InlineData(500000)]
        [InlineData(5000000)]
        public void TestInsertStringLL(int cantidad)
        {
            //Agrega cantidad, inserta cantidad despues del primer indice

            LinkedList<string> list = new LinkedList<string>();
            for (int i = 0; i < cantidad; i++)
            {
                string p = "Esto es una string";

                list.AddLast(p);

            }


            for (int i = cantidad; i < cantidad * 2; i++)
            {
                string p = "Esto es una string";
                list.AddAfter(list.First, p);
            }

        }

        [Theory]
        [InlineData(500)]
        [InlineData(5000)]
        [InlineData(50000)]
        //[InlineData(500000)] >1 minuto
        //[InlineData(5000000)]
        public void TestInsertStringList(int cantidad)
        {
            //Agrega cantidad, inserta cantidad despues del primer indice

            List<int> list = new List<int>();
            for (int i = 0; i < cantidad; i++)
            {
                list.Add(i);
            }

            for (int i = cantidad; i < cantidad * 2; i++)
            {

                list.Insert(1, i);
            }

        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestAddAndRemoveStringLL(int cantidad)
        {
            //Agrega cantidad, despues la elimina uno por uno

            LinkedList<string> list = new LinkedList<string>();
            for (int i = 0; i < cantidad; i++)
            {
                string p = "Esto es una string";
                list.AddLast(p);

            }

            while (list.Count > 0) { list.RemoveFirst(); }

        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        //[InlineData(1000000)] > 2 minutos
        //[InlineData(10000000)]
        public void TestAddAndRemoveStringList(int cantidad)
        {
            //Agrega cantidad, despues la elimina uno por uno

            List<string> list = new List<string>();
            for (int i = 0; i < cantidad; i++)
            {
                string p = "Esto es una string";
                list.Add(p);
            }

            for (int i = 0; i < list.Count; i++)
            {

                list.RemoveAt(i);
            }

        }

    }
}
