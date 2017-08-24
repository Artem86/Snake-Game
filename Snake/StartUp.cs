using StructureMap;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public static class StartUp
    {
        private static Container _container;
        public static Container SnakeContainer
        {
            get
            {
                return _container;
            }
        }
        public static void Configure()
        {
            _container = new Container((_) => {
                _.For<IPointWriter>().Use<ConsolePointWriter>();
            });
        }
    }
}
