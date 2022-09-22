// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeInstanceTypeResourceResponseBody : TeaModel {
        [NameInMap("InstanceTypeResources")]
        [Validation(Required=false)]
        public DescribeInstanceTypeResourceResponseBodyInstanceTypeResources InstanceTypeResources { get; set; }
        public class DescribeInstanceTypeResourceResponseBodyInstanceTypeResources : TeaModel {
            [NameInMap("InstanceTypeResource")]
            [Validation(Required=false)]
            public List<DescribeInstanceTypeResourceResponseBodyInstanceTypeResourcesInstanceTypeResource> InstanceTypeResource { get; set; }
            public class DescribeInstanceTypeResourceResponseBodyInstanceTypeResourcesInstanceTypeResource : TeaModel {
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SearchType")]
                [Validation(Required=false)]
                public string SearchType { get; set; }

                [NameInMap("StockHealth")]
                [Validation(Required=false)]
                public DescribeInstanceTypeResourceResponseBodyInstanceTypeResourcesInstanceTypeResourceStockHealth StockHealth { get; set; }
                public class DescribeInstanceTypeResourceResponseBodyInstanceTypeResourcesInstanceTypeResourceStockHealth : TeaModel {
                    [NameInMap("AdequacyScore")]
                    [Validation(Required=false)]
                    public int? AdequacyScore { get; set; }

                    [NameInMap("HealthScore")]
                    [Validation(Required=false)]
                    public int? HealthScore { get; set; }

                    [NameInMap("HotScore")]
                    [Validation(Required=false)]
                    public int? HotScore { get; set; }

                    [NameInMap("SupplyScore")]
                    [Validation(Required=false)]
                    public int? SupplyScore { get; set; }

                }

                [NameInMap("TotalQuota")]
                [Validation(Required=false)]
                public long? TotalQuota { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
