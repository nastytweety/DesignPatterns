using System;
using System.Collections.Generic;

namespace Builder
{
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }

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


    public class Product
    {
        private List<object> _parts = new List<object>();

        public int _productId { get { return _productId; } set { if (value > 0) _productId = value; } }
        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
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
