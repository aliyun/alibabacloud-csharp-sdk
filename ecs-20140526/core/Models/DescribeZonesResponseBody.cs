// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details about the zones and their supported resources.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
                /// <summary>
                /// <para>The supported dedicated host types.</para>
                /// </summary>
                [NameInMap("AvailableDedicatedHostTypes")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableDedicatedHostTypes AvailableDedicatedHostTypes { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableDedicatedHostTypes : TeaModel {
                    [NameInMap("DedicatedHostType")]
                    [Validation(Required=false)]
                    public List<string> DedicatedHostType { get; set; }

                }

                /// <summary>
                /// <para>The categories of cloud disks that can be created. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud: basic disk</description></item>
                /// <item><description>cloud_ssd: standard SSD</description></item>
                /// <item><description>cloud_efficiency: ultra disk</description></item>
                /// <item><description>cloud_essd: ESSD</description></item>
                /// </list>
                /// </summary>
                [NameInMap("AvailableDiskCategories")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableDiskCategories AvailableDiskCategories { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableDiskCategories : TeaModel {
                    [NameInMap("DiskCategories")]
                    [Validation(Required=false)]
                    public List<string> DiskCategories { get; set; }

                }

                /// <summary>
                /// <para>The supported instance types.</para>
                /// </summary>
                [NameInMap("AvailableInstanceTypes")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableInstanceTypes AvailableInstanceTypes { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableInstanceTypes : TeaModel {
                    [NameInMap("InstanceTypes")]
                    [Validation(Required=false)]
                    public List<string> InstanceTypes { get; set; }

                }

                /// <summary>
                /// <para>The types of resources that can be created. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>VSwitch: vSwitch</description></item>
                /// <item><description>IoOptimized: I/O optimized instance</description></item>
                /// <item><description>Instance: instance</description></item>
                /// <item><description>DedicatedHost: dedicated host</description></item>
                /// <item><description>disk: cloud disk</description></item>
                /// </list>
                /// </summary>
                [NameInMap("AvailableResourceCreation")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableResourceCreation AvailableResourceCreation { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableResourceCreation : TeaModel {
                    [NameInMap("ResourceTypes")]
                    [Validation(Required=false)]
                    public List<string> ResourceTypes { get; set; }

                }

                /// <summary>
                /// <para>Details about the resources that can be created in the zone.</para>
                /// </summary>
                [NameInMap("AvailableResources")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableResources AvailableResources { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableResources : TeaModel {
                    [NameInMap("ResourcesInfo")]
                    [Validation(Required=false)]
                    public List<DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfo> ResourcesInfo { get; set; }
                    public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfo : TeaModel {
                        /// <summary>
                        /// <para>The categories of data disks that can be created.</para>
                        /// </summary>
                        [NameInMap("DataDiskCategories")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoDataDiskCategories DataDiskCategories { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoDataDiskCategories : TeaModel {
                            [NameInMap("supportedDataDiskCategory")]
                            [Validation(Required=false)]
                            public List<string> SupportedDataDiskCategory { get; set; }

                        }

                        /// <summary>
                        /// <para>The supported generations of instance families.</para>
                        /// </summary>
                        [NameInMap("InstanceGenerations")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceGenerations InstanceGenerations { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceGenerations : TeaModel {
                            [NameInMap("supportedInstanceGeneration")]
                            [Validation(Required=false)]
                            public List<string> SupportedInstanceGeneration { get; set; }

                        }

                        /// <summary>
                        /// <para>The supported instance families.</para>
                        /// </summary>
                        [NameInMap("InstanceTypeFamilies")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypeFamilies InstanceTypeFamilies { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypeFamilies : TeaModel {
                            [NameInMap("supportedInstanceTypeFamily")]
                            [Validation(Required=false)]
                            public List<string> SupportedInstanceTypeFamily { get; set; }

                        }

                        /// <summary>
                        /// <para>The supported instance types.</para>
                        /// </summary>
                        [NameInMap("InstanceTypes")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypes InstanceTypes { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypes : TeaModel {
                            [NameInMap("supportedInstanceType")]
                            [Validation(Required=false)]
                            public List<string> SupportedInstanceType { get; set; }

                        }

                        /// <summary>
                        /// <para>Indicates whether the instance is I/O optimized.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("IoOptimized")]
                        [Validation(Required=false)]
                        public bool? IoOptimized { get; set; }

                        /// <summary>
                        /// <para>The supported network types.</para>
                        /// </summary>
                        [NameInMap("NetworkTypes")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoNetworkTypes NetworkTypes { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoNetworkTypes : TeaModel {
                            [NameInMap("supportedNetworkCategory")]
                            [Validation(Required=false)]
                            public List<string> SupportedNetworkCategory { get; set; }

                        }

                        /// <summary>
                        /// <para>The categories of system disks that can be created.</para>
                        /// </summary>
                        [NameInMap("SystemDiskCategories")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoSystemDiskCategories SystemDiskCategories { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoSystemDiskCategories : TeaModel {
                            [NameInMap("supportedSystemDiskCategory")]
                            [Validation(Required=false)]
                            public List<string> SupportedSystemDiskCategory { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The supported Shared Block Storage device categories.</para>
                /// </summary>
                [NameInMap("AvailableVolumeCategories")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableVolumeCategories AvailableVolumeCategories { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableVolumeCategories : TeaModel {
                    [NameInMap("VolumeCategories")]
                    [Validation(Required=false)]
                    public List<string> VolumeCategories { get; set; }

                }

                /// <summary>
                /// <para>The supported generations of dedicated hosts.</para>
                /// </summary>
                [NameInMap("DedicatedHostGenerations")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneDedicatedHostGenerations DedicatedHostGenerations { get; set; }
                public class DescribeZonesResponseBodyZonesZoneDedicatedHostGenerations : TeaModel {
                    [NameInMap("DedicatedHostGeneration")]
                    [Validation(Required=false)]
                    public List<string> DedicatedHostGeneration { get; set; }

                }

                /// <summary>
                /// <para>The name of the zone in the local language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou Zone G</para>
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The type of the zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AvailabilityZone: zone for the Alibaba Cloud public cloud</description></item>
                /// <item><description>CloudBoxZone: zone for CloudBox</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AvailabilityZone</para>
                /// </summary>
                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

    }

}
