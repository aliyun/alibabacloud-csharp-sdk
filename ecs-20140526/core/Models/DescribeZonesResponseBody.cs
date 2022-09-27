// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeZonesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
                [NameInMap("AvailableDedicatedHostTypes")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableDedicatedHostTypes AvailableDedicatedHostTypes { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableDedicatedHostTypes : TeaModel {
                    [NameInMap("DedicatedHostType")]
                    [Validation(Required=false)]
                    public List<string> DedicatedHostType { get; set; }

                }

                [NameInMap("AvailableDiskCategories")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableDiskCategories AvailableDiskCategories { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableDiskCategories : TeaModel {
                    [NameInMap("DiskCategories")]
                    [Validation(Required=false)]
                    public List<string> DiskCategories { get; set; }

                }

                [NameInMap("AvailableInstanceTypes")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableInstanceTypes AvailableInstanceTypes { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableInstanceTypes : TeaModel {
                    [NameInMap("InstanceTypes")]
                    [Validation(Required=false)]
                    public List<string> InstanceTypes { get; set; }

                }

                [NameInMap("AvailableResourceCreation")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableResourceCreation AvailableResourceCreation { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableResourceCreation : TeaModel {
                    [NameInMap("ResourceTypes")]
                    [Validation(Required=false)]
                    public List<string> ResourceTypes { get; set; }

                }

                [NameInMap("AvailableResources")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableResources AvailableResources { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableResources : TeaModel {
                    [NameInMap("ResourcesInfo")]
                    [Validation(Required=false)]
                    public List<DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfo> ResourcesInfo { get; set; }
                    public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfo : TeaModel {
                        [NameInMap("DataDiskCategories")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoDataDiskCategories DataDiskCategories { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoDataDiskCategories : TeaModel {
                            [NameInMap("supportedDataDiskCategory")]
                            [Validation(Required=false)]
                            public List<string> SupportedDataDiskCategory { get; set; }

                        }

                        [NameInMap("InstanceGenerations")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceGenerations InstanceGenerations { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceGenerations : TeaModel {
                            [NameInMap("supportedInstanceGeneration")]
                            [Validation(Required=false)]
                            public List<string> SupportedInstanceGeneration { get; set; }

                        }

                        [NameInMap("InstanceTypeFamilies")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypeFamilies InstanceTypeFamilies { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypeFamilies : TeaModel {
                            [NameInMap("supportedInstanceTypeFamily")]
                            [Validation(Required=false)]
                            public List<string> SupportedInstanceTypeFamily { get; set; }

                        }

                        [NameInMap("InstanceTypes")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypes InstanceTypes { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypes : TeaModel {
                            [NameInMap("supportedInstanceType")]
                            [Validation(Required=false)]
                            public List<string> SupportedInstanceType { get; set; }

                        }

                        [NameInMap("IoOptimized")]
                        [Validation(Required=false)]
                        public bool? IoOptimized { get; set; }

                        [NameInMap("NetworkTypes")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoNetworkTypes NetworkTypes { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoNetworkTypes : TeaModel {
                            [NameInMap("supportedNetworkCategory")]
                            [Validation(Required=false)]
                            public List<string> SupportedNetworkCategory { get; set; }

                        }

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

                [NameInMap("AvailableVolumeCategories")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneAvailableVolumeCategories AvailableVolumeCategories { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableVolumeCategories : TeaModel {
                    [NameInMap("VolumeCategories")]
                    [Validation(Required=false)]
                    public List<string> VolumeCategories { get; set; }

                }

                [NameInMap("DedicatedHostGenerations")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneDedicatedHostGenerations DedicatedHostGenerations { get; set; }
                public class DescribeZonesResponseBodyZonesZoneDedicatedHostGenerations : TeaModel {
                    [NameInMap("DedicatedHostGeneration")]
                    [Validation(Required=false)]
                    public List<string> DedicatedHostGeneration { get; set; }

                }

                [NameInMap("LocalName")]
                [Validation(Required=false)]
                public string LocalName { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

    }

}
