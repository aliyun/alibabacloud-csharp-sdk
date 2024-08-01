// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// Details about the zones in which resources are available.
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
                /// The resources that are available in the zone.
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
                        /// The information about the resources.
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
                                /// The maximum disk capacity.
                                /// 
                                /// This parameter takes effect only if DestinationResource is set to SystemDisk or DataDisk.
                                /// </summary>
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public int? Max { get; set; }

                                /// <summary>
                                /// The minimum disk capacity.
                                /// 
                                /// This parameter takes effect only if DestinationResource is set to SystemDisk or DataDisk.
                                /// </summary>
                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public int? Min { get; set; }

                                /// <summary>
                                /// The status of the resource. Valid values:
                                /// 
                                /// *   Available
                                /// *   SoldOut
                                /// </summary>
                                [NameInMap("Status")]
                                [Validation(Required=false)]
                                public string Status { get; set; }

                                /// <summary>
                                /// The resource category based on the stock level. Valid values:
                                /// 
                                /// *   WithStock: Resources are in sufficient stock.
                                /// *   ClosedWithStock: Resources are in insufficient stock. We recommend that you use other resources that are in sufficient stock.
                                /// *   WithoutStock: Resources are out of stock and will be replenished. We recommend that you use other resources that are in sufficient stock.
                                /// *   ClosedWithoutStock: Resources are out of stock and will not be replenished. We recommend that you use other resources that are in sufficient stock.
                                /// </summary>
                                [NameInMap("StatusCategory")]
                                [Validation(Required=false)]
                                public string StatusCategory { get; set; }

                                /// <summary>
                                /// The unit of the disk capacity.
                                /// 
                                /// This parameter takes effect only if DestinationResource is set to SystemDisk or DataDisk.
                                /// </summary>
                                [NameInMap("Unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// The resource.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// The resource type. Valid values:
                        /// 
                        /// *   Zone: zone
                        /// *   IoOptimized: I/O optimized resource
                        /// *   InstanceType: instance type
                        /// *   SystemDisk: system disk
                        /// *   DataDisk: data disk
                        /// *   Network: network type
                        /// *   ddh: dedicated host
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The status of resources in the zone. Valid values:
                /// 
                /// *   Available
                /// *   SoldOut
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The resource category based on the stock level in the zone. Valid values:
                /// 
                /// *   WithStock: Resources are in sufficient stock.
                /// *   ClosedWithStock: Resources are in insufficient stock. We recommend that you use other resources that are in sufficient stock.
                /// *   WithoutStock: Resources are out of stock and will be replenished. We recommend that you use other resources that are in sufficient stock.
                /// *   ClosedWithoutStock: Resources are out of stock and will not be replenished. We recommend that you use other resources that are in sufficient stock.
                /// </summary>
                [NameInMap("StatusCategory")]
                [Validation(Required=false)]
                public string StatusCategory { get; set; }

                /// <summary>
                /// The zone ID.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

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
