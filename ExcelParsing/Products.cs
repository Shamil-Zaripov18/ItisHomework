using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelParsing
{
    class Products
    {
        enum Priority
        {
            Low,
            Medium,
            High,
            Critical,
            NotSpecified
        }
        enum Ship
        {
            RegularAir,
            DeliveryTruck,
            ExpressAir
        }
        enum Segment
        {
            SmallBusiness,
            Consumer,
            Corporate,
            HomeOffice
        }
        enum Category
        {
            OfficeSupplies,
            Technology,
            Furniture
        }
        enum Container
        {
            JumboDrum,
            JumboBox,
            SmallBox,
            MediumBox,
            LargeBox,
            SmallPack,
            WrapBag
        }
        class Product
        {
            public int RowId { get; set; }
            public int OrderId { get; set; }
            public DateTime OrderDate { get; set; }
            public Priority OrderPriority { get; set; }
            public int OrderQuantity { get; set; }
            public double Sales { get; set; }
            public double Discount { get; set; }
            public Ship ShipMode { get; set; }
            public double Profit { get; set; }
            public double UnitPrice { get; set; }
            public double ShippingCost { get; set; }
            public string CustomerName { get; set; }
            public string Province { get; set; }
            public string Region { get; set; }
            public Segment CustomerSegment { get; set; }
            public Category ProductCategory { get; set; }
            public string ProductSubCategory { get; set; }
            public string ProductName { get; set; }
            public Container ProductContainer { get; set; }
            public double ProductBaseMargin { get; set; }
            public DateTime ShipDate { get; set; }

        }
    }
}
