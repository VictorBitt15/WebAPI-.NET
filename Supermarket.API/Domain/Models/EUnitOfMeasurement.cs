using System.ComponentModel;

namespace Supermarket.API.Domain.Models
{
    public enum EUnitOfMeasurement: byte
    {
        [Description("UN")]
        Unity = 1,

        [Description("MG")]
        Miligrama = 2,

        [Description("G")]
        Grama = 3,

        [Description("KG")]
        Quilograma = 4,

        [Description("L")]
        Litro =5,
        
    }
}