// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRecommendInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// Details about the recommended instance types.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeRecommendInstanceTypeResponseBodyData Data { get; set; }
        public class DescribeRecommendInstanceTypeResponseBodyData : TeaModel {
            [NameInMap("RecommendInstanceType")]
            [Validation(Required=false)]
            public List<DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceType> RecommendInstanceType { get; set; }
            public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceType : TeaModel {
                /// <summary>
                /// The commodity code of the instance type.
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// The billing method of the instance.
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// The name of the instance type.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeInstanceType InstanceType { get; set; }
                public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeInstanceType : TeaModel {
                    /// <summary>
                    /// The number of vCPUs of the instance type.
                    /// </summary>
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public int? Cores { get; set; }

                    /// <summary>
                    /// The generation of the instance family.
                    /// </summary>
                    [NameInMap("Generation")]
                    [Validation(Required=false)]
                    public string Generation { get; set; }

                    /// <summary>
                    /// The name of the instance type.
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// The instance family.
                    /// </summary>
                    [NameInMap("InstanceTypeFamily")]
                    [Validation(Required=false)]
                    public string InstanceTypeFamily { get; set; }

                    /// <summary>
                    /// The memory size of the instance type. Unit: MB.
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    /// <summary>
                    /// Indicates whether the instance type supports I/O optimization.
                    /// </summary>
                    [NameInMap("SupportIoOptimized")]
                    [Validation(Required=false)]
                    public string SupportIoOptimized { get; set; }

                }

                /// <summary>
                /// The network type of the instance.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The priority based on which the system sorts the instance types.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The region ID of the instance type.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The scenarios in which the instance type is recommended.
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// The bidding policy for the preemptible instance.
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// The ID of the zone in which the instance type is available.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// Details about zones where the instance types resides.
                /// </summary>
                [NameInMap("Zones")]
                [Validation(Required=false)]
                public DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZones Zones { get; set; }
                public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZones : TeaModel {
                    [NameInMap("zone")]
                    [Validation(Required=false)]
                    public List<DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZonesZone> Zone { get; set; }
                    public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZonesZone : TeaModel {
                        /// <summary>
                        /// Details about network types of instance types.
                        /// </summary>
                        [NameInMap("NetworkTypes")]
                        [Validation(Required=false)]
                        public DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZonesZoneNetworkTypes NetworkTypes { get; set; }
                        public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeZonesZoneNetworkTypes : TeaModel {
                            [NameInMap("NetworkType")]
                            [Validation(Required=false)]
                            public List<string> NetworkType { get; set; }

                        }

                        /// <summary>
                        /// The ID of the zone in which the instance type is available.
                        /// </summary>
                        [NameInMap("ZoneNo")]
                        [Validation(Required=false)]
                        public string ZoneNo { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
