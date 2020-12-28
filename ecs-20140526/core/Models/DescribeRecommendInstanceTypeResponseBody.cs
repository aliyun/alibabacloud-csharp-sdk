// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRecommendInstanceTypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeRecommendInstanceTypeResponseBodyData> Data { get; set; }
        public class DescribeRecommendInstanceTypeResponseBodyData : TeaModel {
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<DescribeRecommendInstanceTypeResponseBodyDataZones> Zones { get; set; }
            public class DescribeRecommendInstanceTypeResponseBodyDataZones : TeaModel {
                [NameInMap("ZoneNo")]
                [Validation(Required=false)]
                public string ZoneNo { get; set; }

                [NameInMap("NetworkTypes")]
                [Validation(Required=false)]
                public List<string> NetworkTypes { get; set; }

            }

            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public DescribeRecommendInstanceTypeResponseBodyDataInstanceType InstanceType { get; set; }
            public class DescribeRecommendInstanceTypeResponseBodyDataInstanceType : TeaModel {
                [NameInMap("SupportIoOptimized")]
                [Validation(Required=false)]
                public string SupportIoOptimized { get; set; }
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }
                [NameInMap("Generation")]
                [Validation(Required=false)]
                public string Generation { get; set; }
            };

            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            [NameInMap("SpotStrategy")]
            [Validation(Required=false)]
            public string SpotStrategy { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

        }

    }

}
