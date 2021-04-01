using KB.Entity.Sample;
using ZZH.DapperExpression.Service;

namespace KB.MySqlRepository.EntityConfigMappers
{
    /// <summary>
    /// Produce 实体配置，用于示例
    /// </summary>
    internal class ProductEntityTypeConfigMapperSample : EntityTypeConfigMapper<Product2>
    {
        public ProductEntityTypeConfigMapperSample()
        {
            Table("product");
        }
    }
}
