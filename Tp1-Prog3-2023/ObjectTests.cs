using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Prog3_2023
{
    public class ObjectTests
    {

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestAddObjectLL(int cantidad)
        {
            LinkedList<Persona> list = new();
            

            for (int i = 0; i < cantidad; i++)
            {
                Persona p = new(i,"","","","","","","","","");
                list.AddLast(p);
            }
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestAddObjectList(int cantidad)
        {
            List<Persona> list = new();
            for (int i = 0; i < cantidad; i++)
            {
                Persona p = new(i, "", "", "", "", "", "", "", "", "");
                list.Add(p);
            }
        }


        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(1000000)]
        [InlineData(10000000)]
        public void TestInsertObjectLL(int cantidad)
        {
            //Agrega cantidad, inserta cantidad despues del primer indice

            LinkedList<Persona> list = new LinkedList<Persona>();
            for (int i = 0; i < cantidad; i++)
            {
                Persona p = new(i, "", "", "", "", "", "", "", "", "");

                list.AddLast(p);

            }


            for (int i = cantidad; i < cantidad * 2; i++)
            {
                Persona p = new(i, "", "", "", "", "", "", "", "", "");
                list.AddAfter(list.First, p);
            }

        }

        [Theory]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        //[InlineData(1000000)] >1 minuto
        //[InlineData(10000000)]
        public void TestInsertObjectList(int cantidad)
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
        public void TestAddAndRemoveObjectLL(int cantidad)
        {
            //Agrega cantidad, despues la elimina uno por uno

            LinkedList<Persona> list = new LinkedList<Persona>();
            for (int i = 0; i < cantidad; i++)
            {
                Persona p = new(i, "", "", "", "", "", "", "", "", "");
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
        public void TestAddAndRemoveObjectList(int cantidad)
        {
            //Agrega cantidad, despues la elimina uno por uno

            List<Persona> list = new List<Persona>();
            for (int i = 0; i < cantidad; i++)
            {
                Persona p = new(i, "", "", "", "", "", "", "", "", "");
                list.Add(p);
            }

            for (int i = 0; i < list.Count; i++)
            {

                list.RemoveAt(i);
            }

        }

    }
}
