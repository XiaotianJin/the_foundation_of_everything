using System;
using Design_Patterns_CSharp.Creaters.AbstractFactory.Products;

namespace Design_Patterns_CSharp.Creaters.AbstractFactory.Factories
{
    /// <summary>
    /// 实例工厂
    /// </summary>
    class ConcreteFactory : FactoryBase
    {
        /// <summary>
        /// 构造一个实例产品
        /// </summary>
        /// <returns></returns>
        public ProductBase CreateProduct()
        {
            Console.WriteLine("Creating Product");
            // 进行构造
            return null;
        }
    }
}
