// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRecommendInstanceTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the recommended instance types.</para>
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
                /// <para>The commodity code of the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                /// <summary>
                /// <para>The billing method of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                /// <summary>
                /// <para>The name of the instance type.</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeInstanceType InstanceType { get; set; }
                public class DescribeRecommendInstanceTypeResponseBodyDataRecommendInstanceTypeInstanceType : TeaModel {
                    /// <summary>
                    /// <para>The number of vCPUs of the instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public int? Cores { get; set; }

                    /// <summary>
                    /// <para>The generation of the instance family.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs-4</para>
                    /// </summary>
                    [NameInMap("Generation")]
                    [Validation(Required=false)]
                    public string Generation { get; set; }

                    /// <summary>
                    /// <para>The name of the instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs.hfg6.large</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>The instance family.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs.hfg6</para>
                    /// </summary>
                    [NameInMap("InstanceTypeFamily")]
                    [Validation(Required=false)]
                    public string InstanceTypeFamily { get; set; }

                    /// <summary>
                    /// <para>The memory size of the instance type. Unit: MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8192</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the instance type supports I/O optimization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>optimized</para>
                    /// </summary>
                    [NameInMap("SupportIoOptimized")]
                    [Validation(Required=false)]
                    public string SupportIoOptimized { get; set; }

                }

                /// <summary>
                /// <para>The network type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The priority based on which the system sorts the instance types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The region ID of the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The scenarios in which the instance type is recommended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CREATE</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The bidding policy for the preemptible instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NoSpot</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

                /// <summary>
                /// <para>The ID of the zone in which the instance type is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The details of the zones where the instance types resides.</para>
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
                        /// <para>The details of network types of instance types.</para>
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
                        /// <para>The ID of the zone where the instance type is available.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou-h</para>
                        /// </summary>
                        [NameInMap("ZoneNo")]
                        [Validation(Required=false)]
                        public string ZoneNo { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
