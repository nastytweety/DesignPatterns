using System;
using System.Collections.Generic;

namespace Builder
{

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }

        public Product Build()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom product:");
            var builder = new ConcreteBuilder();
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
            var product = builder.Build();
            Console.WriteLine(product.ListParts());
            Console.ReadLine();
        }
    }
}
