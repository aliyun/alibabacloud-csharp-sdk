// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeResourcesModificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the queried zones.</para>
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
                /// <para>The resources that are available in the zone.</para>
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
                        /// <para>The resource types that resources can be changed to after the resources meet specified conditions. If the conditions are met, you can change the current resource to a resource in the list.</para>
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
                                /// <para>The conditions.</para>
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
                                        /// <para>The condition name. Valid value:</para>
                                        /// <para>DiskCategory, which indicates a disk category change.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>DiskCategory</para>
                                        /// </summary>
                                        [NameInMap("Key")]
                                        [Validation(Required=false)]
                                        public string Key { get; set; }

                                    }

                                }

                                /// <summary>
                                /// <para>The maximum disk capacity.</para>
                                /// <para>This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public int? Max { get; set; }

                                /// <summary>
                                /// <para>The minimum disk capacity.</para>
                                /// <para>This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public int? Min { get; set; }

                                /// <summary>
                                /// <para>The stock state of the resource. Valid values:</para>
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
                                /// <para>The category of the resource based on stock status. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>WithStock: resources that are in sufficient stock</description></item>
                                /// <item><description>ClosedWithStock: resources that are in insufficient stock</description></item>
                                /// <item><description>WithoutStock: resources that are out of stock</description></item>
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
                                /// <para>This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>null</para>
                                /// </summary>
                                [NameInMap("Unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// <para>The resource type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ecs.g5.large</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The information about the resources.</para>
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
                                /// <para>The maximum disk capacity.</para>
                                /// <para>This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2</para>
                                /// </summary>
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public int? Max { get; set; }

                                /// <summary>
                                /// <para>The minimum disk capacity.</para>
                                /// <para>This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public int? Min { get; set; }

                                /// <summary>
                                /// <para>The state of the resource. Valid values:</para>
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
                                /// <para>The category of the resource based on stock status. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description>WithStock: resources that are in sufficient stock</description></item>
                                /// <item><description>ClosedWithStock: resources that are in insufficient stock</description></item>
                                /// <item><description>WithoutStock: resources that are out of stock</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>WithStock</para>
                                /// </summary>
                                [NameInMap("StatusCategory")]
                                [Validation(Required=false)]
                                public string StatusCategory { get; set; }

                                /// <summary>
                                /// <para>The unit of the disk capacity. This parameter takes effect only when the DestinationResource request parameter is set to SystemDisk.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>null</para>
                                /// </summary>
                                [NameInMap("Unit")]
                                [Validation(Required=false)]
                                public string Unit { get; set; }

                                /// <summary>
                                /// <para>The resource type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ecs.g5.large</para>
                                /// </summary>
                                [NameInMap("Value")]
                                [Validation(Required=false)]
                                public string Value { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The type of the resources. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Zone</description></item>
                        /// <item><description>IoOptimized</description></item>
                        /// <item><description>InstanceType</description></item>
                        /// <item><description>SystemDisk</description></item>
                        /// <item><description>DataDisk</description></item>
                        /// <item><description>Network</description></item>
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
                /// <para>The state of the resource. Valid values:</para>
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
                /// <para>The category of the resource based on stock status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>WithStock: resources that are in sufficient stock</description></item>
                /// <item><description>ClosedWithStock: resources that are in insufficient stock</description></item>
                /// <item><description>WithoutStock: resources that are out of stock</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
