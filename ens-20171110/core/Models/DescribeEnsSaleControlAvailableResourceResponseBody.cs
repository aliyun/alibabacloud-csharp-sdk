// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeEnsSaleControlAvailableResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SaleControlAvailableResource")]
        [Validation(Required=false)]
        public List<DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResource> SaleControlAvailableResource { get; set; }
        public class DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResource : TeaModel {
            [NameInMap("AvailableDiskType")]
            [Validation(Required=false)]
            public List<DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableDiskType> AvailableDiskType { get; set; }
            public class DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableDiskType : TeaModel {
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            [NameInMap("AvailableRegion")]
            [Validation(Required=false)]
            public List<DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableRegion> AvailableRegion { get; set; }
            public class DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableRegion : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                [NameInMap("EnsRegionName")]
                [Validation(Required=false)]
                public string EnsRegionName { get; set; }

                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

            }

            [NameInMap("AvailableSpec")]
            [Validation(Required=false)]
            public List<DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableSpec> AvailableSpec { get; set; }
            public class DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableSpec : TeaModel {
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public string Cores { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                [NameInMap("SpecName")]
                [Validation(Required=false)]
                public string SpecName { get; set; }

                [NameInMap("SpecValue")]
                [Validation(Required=false)]
                public string SpecValue { get; set; }

            }

            [NameInMap("AvailableStorageType")]
            [Validation(Required=false)]
            public DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableStorageType AvailableStorageType { get; set; }
            public class DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableStorageType : TeaModel {
                [NameInMap("AvailableDefaultStorageType")]
                [Validation(Required=false)]
                public List<DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableStorageTypeAvailableDefaultStorageType> AvailableDefaultStorageType { get; set; }
                public class DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableStorageTypeAvailableDefaultStorageType : TeaModel {
                    [NameInMap("StorageName")]
                    [Validation(Required=false)]
                    public string StorageName { get; set; }

                    [NameInMap("StorageType")]
                    [Validation(Required=false)]
                    public string StorageType { get; set; }

                }

                [NameInMap("AvailableSpecialStorageType")]
                [Validation(Required=false)]
                public List<List<DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableStorageTypeAvailableSpecialStorageType>> AvailableSpecialStorageType { get; set; }
                public class DescribeEnsSaleControlAvailableResourceResponseBodySaleControlAvailableResourceAvailableStorageTypeAvailableSpecialStorageType : TeaModel {
                    [NameInMap("StorageType")]
                    [Validation(Required=false)]
                    public string StorageType { get; set; }

                    [NameInMap("StorageName")]
                    [Validation(Required=false)]
                    public string StorageName { get; set; }

                    [NameInMap("EnsRegionId")]
                    [Validation(Required=false)]
                    public string EnsRegionId { get; set; }

                }

            }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

        }

    }

}
