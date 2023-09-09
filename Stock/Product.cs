using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class Product
    {
        int id;
        string number;
        string name;
        double cost;
        int count;
        public int getid() { return id; }
        public string getnum() { return number; }
        public string getname() { return name; }
        public double getcost() { return cost; }
        public int getcount() { return count; }
        public Product(int id, string number = "000000", string name = "default", double cost = 0, int count = 0)
        {
            if (number.Length == 6 && cost >= 0)
            {
                this.id = id;
                this.number = number;
                this.name = name;
                this.cost = cost;
                this.count = count;
            }
        }
        public string show()
        {
            return id + " " + number + " " + name + " " + cost + " " + count;
        }
    }
    class Base
    {
        Product[] products = new Product[10];
        int size = 0;
        int capacity = 10;
        public void add(string number = "000000", string name = "default", int cost = 0, int count = 0)
        {
            if (size == capacity - 1)
                upsize();
            products[size] = new Product(size, number, name, cost, count);
            ++size;
        }
        public string select()
        {
            string result = "";
            for (int i = 0; i < size; ++i)
            {
                result += products[i].show() + "\n";
            }
            return result;
        }
        private void upsize()
        {
            capacity *= 2;
            Product[] temp = new Product[capacity];
            products.CopyTo(temp, 0);
            this.products = temp;
        }
    }
}
