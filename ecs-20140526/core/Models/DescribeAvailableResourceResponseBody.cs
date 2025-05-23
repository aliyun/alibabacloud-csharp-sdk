// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the zones in which resources are available.</para>
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
                /// <para>The resources that are available in the zone.</para>
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
                        /// <para>The information about the resources.</para>
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
                                /// <para>The maximum disk capacity.</para>
                                /// <para>This parameter takes effect only if DestinationResource is set to SystemDisk or DataDisk.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public int? Max { get; set; }

                                /// <summary>
                                /// <para>The minimum disk capacity.</para>
                                /// <para>This parameter takes effect only if DestinationResource is set to SystemDisk or DataDisk.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public int? Min { get; set; }

                                /// <summary>
                                /// <para>The status of the resource. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>Available</description></item>
                                /// <item><description>SoldOut</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Available</para>
                                /// </summary>
                                [NameInMap("Status")]
                                [Validation(Required=false)]
                                public string Status { get; set; }

                                /// <summary>
                                /// <para>The resource category based on the stock level. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>WithStock: Resources are in sufficient stock.</description></item>
                                /// <item><description>ClosedWithStock: Resources are in insufficient stock. We recommend that you use other resources that are in sufficient stock.</description></item>
                                /// <item><description>WithoutStock: Resources are out of stock and will be replenished. We recommend that you use other resources that are in sufficient stock.</description></item>
                                /// <item><description>ClosedWithoutStock: Resources are out of stock and will not be replenished. We recommend that you use other resources that are in sufficient stock.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>WithStock</para>
                                /// </summary>
                                [NameInMap("StatusCategory")]
                                [Validation(Required=false)]
                                public string StatusCategory { get; set; }

                                /// <summary>
                                /// <para>The unit of the disk capacity.</para>
                                /// <para>This parameter takes effect only if DestinationResource is set to SystemDisk or DataDisk.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>null</para>
                                /// </summary>
                                [NameInMap("Unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// <para>The resource.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ecs.d1ne.xlarge</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The resource type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Zone: zone</description></item>
                        /// <item><description>IoOptimized: I/O optimized resource</description></item>
                        /// <item><description>InstanceType: instance type</description></item>
                        /// <item><description>SystemDisk: system disk</description></item>
                        /// <item><description>DataDisk: data disk</description></item>
                        /// <item><description>Network: network type</description></item>
                        /// <item><description>ddh: dedicated host</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>InstanceType</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of resources in the zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Available</description></item>
                /// <item><description>SoldOut</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The resource category based on the stock level in the zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>WithStock: Resources are in sufficient stock.</description></item>
                /// <item><description>ClosedWithStock: Resources are in insufficient stock. We recommend that you use other resources that are in sufficient stock.</description></item>
                /// <item><description>WithoutStock: Resources are out of stock and will be replenished. We recommend that you use other resources that are in sufficient stock.</description></item>
                /// <item><description>ClosedWithoutStock: Resources are out of stock and will not be replenished. We recommend that you use other resources that are in sufficient stock.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>WithStock</para>
                /// </summary>
                [NameInMap("StatusCategory")]
                [Validation(Required=false)]
                public string StatusCategory { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0041D94C-FB92-4C49-B115-259DA1C*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
