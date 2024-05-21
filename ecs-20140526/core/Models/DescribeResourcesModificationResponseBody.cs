// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeResourcesModificationResponseBody : TeaModel {
        /// <summary>
        /// The information about the queried zones.
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeResourcesModificationResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeResourcesModificationResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeResourcesModificationResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZone : TeaModel {
                /// <summary>
                /// The resources that are available in the zone.
                /// </summary>
                [NameInMap("AvailableResources")]
                [Validation(Required=false)]
                public DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResources AvailableResources { get; set; }
                public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResources : TeaModel {
                    [NameInMap("AvailableResource")]
                    [Validation(Required=false)]
                    public List<DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResource> AvailableResource { get; set; }
                    public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResource : TeaModel {
                        /// <summary>
                        /// The resource types that resources can be changed to after the resources meet specified conditions. If the conditions are met, you can change the current resource to a resource in the list.
                        /// </summary>
                        [NameInMap("ConditionSupportedResources")]
                        [Validation(Required=false)]
                        public DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceConditionSupportedResources ConditionSupportedResources { get; set; }
                        public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceConditionSupportedResources : TeaModel {
                            [NameInMap("ConditionSupportedResource")]
                            [Validation(Required=false)]
                            public List<DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceConditionSupportedResourcesConditionSupportedResource> ConditionSupportedResource { get; set; }
                            public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceConditionSupportedResourcesConditionSupportedResource : TeaModel {
                                /// <summary>
                                /// The conditions.
                                /// </summary>
                                [NameInMap("Conditions")]
                                [Validation(Required=false)]
                                public DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceConditionSupportedResourcesConditionSupportedResourceConditions Conditions { get; set; }
                                public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceConditionSupportedResourcesConditionSupportedResourceConditions : TeaModel {
                                    [NameInMap("Condition")]
                                    [Validation(Required=false)]
                                    public List<DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceConditionSupportedResourcesConditionSupportedResourceConditionsCondition> Condition { get; set; }
                                    public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceConditionSupportedResourcesConditionSupportedResourceConditionsCondition : TeaModel {
                                        /// <summary>
                                        /// The condition name. Valid value:
                                        /// 
                                        /// DiskCategory, which indicates a disk category change.
                                        /// </summary>
                                        [NameInMap("Key")]
                                        [Validation(Required=false)]
                                        public string Key { get; set; }

                                    }

                                }

                                /// <summary>
                                /// The maximum disk capacity.
                                /// 
                                /// This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.
                                /// </summary>
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public int? Max { get; set; }

                                /// <summary>
                                /// The minimum disk capacity.
                                /// 
                                /// This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.
                                /// </summary>
                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public int? Min { get; set; }

                                /// <summary>
                                /// The stock state of the resource. Valid values:
                                /// 
                                /// *   Available
                                /// *   SoldOut
                                /// </summary>
                                [NameInMap("Status")]
                                [Validation(Required=false)]
                                public string Status { get; set; }

                                /// <summary>
                                /// The category of the resource based on stock status. Valid values:
                                /// 
                                /// *   WithStock: resources that are in sufficient stock
                                /// *   ClosedWithStock: resources that are in insufficient stock
                                /// *   WithoutStock: resources that are out of stock
                                /// </summary>
                                [NameInMap("StatusCategory")]
                                [Validation(Required=false)]
                                public string StatusCategory { get; set; }

                                /// <summary>
                                /// The unit of the disk capacity.
                                /// 
                                /// This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.
                                /// </summary>
                                [NameInMap("Unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// The resource type.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// The information about the resources.
                        /// </summary>
                        [NameInMap("SupportedResources")]
                        [Validation(Required=false)]
                        public DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResources SupportedResources { get; set; }
                        public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResources : TeaModel {
                            [NameInMap("SupportedResource")]
                            [Validation(Required=false)]
                            public List<DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResourcesSupportedResource> SupportedResource { get; set; }
                            public class DescribeResourcesModificationResponseBodyAvailableZonesAvailableZoneAvailableResourcesAvailableResourceSupportedResourcesSupportedResource : TeaModel {
                                /// <summary>
                                /// The maximum disk capacity.
                                /// 
                                /// This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.
                                /// </summary>
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public int? Max { get; set; }

                                /// <summary>
                                /// The minimum disk capacity.
                                /// 
                                /// This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.
                                /// </summary>
                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public int? Min { get; set; }

                                /// <summary>
                                /// The state of the resource. Valid values:
                                /// 
                                /// *   Available
                                /// *   SoldOut
                                /// </summary>
                                [NameInMap("Status")]
                                [Validation(Required=false)]
                                public string Status { get; set; }

                                /// <summary>
                                /// The category of the resource based on stock status. Valid values:
                                /// 
                                /// *   WithStock: resources that are in sufficient stock
                                /// *   ClosedWithStock: resources that are in insufficient stock
                                /// *   WithoutStock: resources that are out of stock
                                /// </summary>
                                [NameInMap("StatusCategory")]
                                [Validation(Required=false)]
                                public string StatusCategory { get; set; }

                                /// <summary>
                                /// The unit of the disk capacity. This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.
                                /// </summary>
                                [NameInMap("Unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// The resource type.
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// The type of the resources. Valid values:
                        /// 
                        /// *   Zone
                        /// *   IoOptimized
                        /// *   InstanceType
                        /// *   SystemDisk
                        /// *   DataDisk
                        /// *   Network
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
                /// The state of the resource. Valid values:
                /// 
                /// *   Available
                /// *   SoldOut
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The category of the resource based on stock status. Valid values:
                /// 
                /// *   WithStock: resources that are in sufficient stock
                /// *   ClosedWithStock: resources that are in insufficient stock
                /// *   WithoutStock: resources that are out of stock
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
