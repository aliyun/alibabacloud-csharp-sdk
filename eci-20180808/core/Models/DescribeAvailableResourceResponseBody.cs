// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The zones in which the specified resources are available.</para>
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone : TeaModel {
                /// <summary>
                /// <para>The resources that are available in the specified zone.</para>
                /// </summary>
                [NameInMap("AvailableResources")]
                [Validation(Required=false)]
                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneAvailableResources AvailableResources { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneAvailableResources : TeaModel {
                    [NameInMap("AvailableResource")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResource> AvailableResource { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResource : TeaModel {
                        /// <summary>
                        /// <para>The information about the resources that are available in the zones.</para>
                        /// </summary>
                        [NameInMap("SupportedResources")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResources SupportedResources { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResources : TeaModel {
                            [NameInMap("SupportedResource")]
                            [Validation(Required=false)]
                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResourcesSupportedResource> SupportedResource { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResourcesSupportedResource : TeaModel {
                                /// <summary>
                                /// <para>The category of resources based on stock status. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>WithStock: Resources are in sufficient stock.</description></item>
                                /// <item><description>ClosedWithStock: Resources are insufficient. We recommend that you use instance types that are in sufficient stock.</description></item>
                                /// <item><description>WithoutStock: Resources are sold out and will be replenished. We recommend that you use instance types that are in sufficient stock.</description></item>
                                /// <item><description>ClosedWithoutStock: Resources are sold out and will not be replenished. We recommend that you use instance types that are in sufficient stock.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>WithStock</para>
                                /// </summary>
                                [NameInMap("StatusCategory")]
                                [Validation(Required=false)]
                                public string StatusCategory { get; set; }

                                /// <summary>
                                /// <para>The ECS instance types or instance families that are available in the zones.</para>
                                /// <list type="bullet">
                                /// <item><description>If the return value of the Type parameter is InstanceTypeFamily, this parameter indicates instance families that are returned.</description></item>
                                /// <item><description>If the return value of the Type parameter is InstanceType, this parameter indicates instance types that are returned.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ecs.c6</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The type of the resource. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>InstanceTypeFamily: instance families.</description></item>
                        /// <item><description>InstanceType: instance types.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>InstanceTypeFamily</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The region ID of the resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The zone ID of the resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-e</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6829735A-FF76-58C6-AECB-27CBF135A7AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
