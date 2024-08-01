// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details of the zones and their supported resources.
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
                /// The supported dedicated host types.
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
                /// The supported disk categories. Valid values:
                /// 
                /// *   cloud: basic disk
                /// *   cloud_ssd: standard SSD
                /// *   cloud_efficiency: ultra disk
                /// *   cloud_essd: ESSD
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
                /// The supported instance types.
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
                /// The types of resources that can be created. Valid values:
                /// 
                /// *   VSwitch: vSwitch
                /// *   IoOptimized: I/O optimized instance
                /// *   Instance: instance
                /// *   DedicatedHost: dedicated host
                /// *   disk: disk
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
                /// Details about the resources that can be created in the zone.
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
                        /// The categories of data disks that can be created.
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
                        /// The supported generations of instance families.
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
                        /// The supported instance families.
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
                        /// The supported instance types.
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
                        /// Indicates whether the instance is I/O optimized.
                        /// </summary>
                        [NameInMap("IoOptimized")]
                        [Validation(Required=false)]
                        public bool? IoOptimized { get; set; }

                        /// <summary>
                        /// The supported network types
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
                        /// The supported categories of system disks that can be created.
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
                /// The supported Shared Block Storage device categories.
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
                /// The supported generations of dedicated hosts.
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
                /// The name of the zone in the local language.
                /// </summary>
                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                /// <summary>
                /// The ID of the zone.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The type of the zone. Valid values:
                /// 
                /// *   AvailabilityZone: zone for the Alibaba Cloud public cloud
                /// *   CloudBoxZone: zone for CloudBox
                /// </summary>
                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

    }

}
