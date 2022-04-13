// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRecommendInstanceTypeResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeRecommendInstanceTypeResponseBodyData Data { get; set; }
        public class DescribeRecommendInstanceTypeResponseBodyData : TeaModel {
            [NameInMap("RecommendInstanceType")]
            [Validation(Required=false)]
            public List<DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceType> RecommendInstanceType { get; set; }
            public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceType : TeaModel {
                public string CommodityCode { get; set; }
                public string InstanceChargeType { get; set; }
                public DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeInstanceType InstanceType { get; set; }
                public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeInstanceType : TeaModel {
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public int? Cores { get; set; }

                    [NameInMap("Generation")]
                    [Validation(Required=false)]
                    public string Generation { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("InstanceTypeFamily")]
                    [Validation(Required=false)]
                    public string InstanceTypeFamily { get; set; }

                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    [NameInMap("SupportIoOptimized")]
                    [Validation(Required=false)]
                    public string SupportIoOptimized { get; set; }

                }
                public string NetworkType { get; set; }
                public int? Priority { get; set; }
                public string RegionId { get; set; }
                public string Scene { get; set; }
                public string SpotStrategy { get; set; }
                public string ZoneId { get; set; }
                public DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZones Zones { get; set; }
                public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZones : TeaModel {
                    [NameInMap("zone")]
                    [Validation(Required=false)]
                    public List<DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZonesZone> Zone { get; set; }
                    public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZonesZone : TeaModel {
                        [NameInMap("NetworkTypes")]
                        [Validation(Required=false)]
                        public DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZonesZoneNetworkTypes NetworkTypes { get; set; }
                        public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZonesZoneNetworkTypes : TeaModel {
                            [NameInMap("NetworkType")]
                            [Validation(Required=false)]
                            public List<string> NetworkType { get; set; }
                        };

                        [NameInMap("ZoneNo")]
                        [Validation(Required=false)]
                        public string ZoneNo { get; set; }

                    }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
