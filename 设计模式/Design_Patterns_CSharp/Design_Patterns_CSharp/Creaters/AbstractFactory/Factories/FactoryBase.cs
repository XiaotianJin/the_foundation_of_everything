using Design_Patterns_CSharp.Creaters.AbstractFactory.Products;

namespace Design_Patterns_CSharp.Creaters.AbstractFactory.Factories
{
    /// <summary>
    /// 抽象工厂接口
    /// </summary>
    interface FactoryBase
    {
        // 构造一个产品
        ProductBase CreateProduct();
    }
}
