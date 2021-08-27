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
                public string ZoneId { get; set; }
                public string LocalName { get; set; }
                public DescribeZonesResponseBodyZonesZoneAvailableResources AvailableResources { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableResources : TeaModel {
                    [NameInMap("ResourcesInfo")]
                    [Validation(Required=false)]
                    public List<DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfo> ResourcesInfo { get; set; }
                    public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfo : TeaModel {
                        [NameInMap("IoOptimized")]
                        [Validation(Required=false)]
                        public bool? IoOptimized { get; set; }

                        [NameInMap("SystemDiskCategories")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoSystemDiskCategories SystemDiskCategories { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoSystemDiskCategories : TeaModel {
                            [NameInMap("supportedSystemDiskCategory")]
                            [Validation(Required=false)]
                            public List<string> SupportedSystemDiskCategory { get; set; }
                        };

                        [NameInMap("InstanceGenerations")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceGenerations InstanceGenerations { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceGenerations : TeaModel {
                            [NameInMap("supportedInstanceGeneration")]
                            [Validation(Required=false)]
                            public List<string> SupportedInstanceGeneration { get; set; }
                        };

                        [NameInMap("DataDiskCategories")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoDataDiskCategories DataDiskCategories { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoDataDiskCategories : TeaModel {
                            [NameInMap("supportedDataDiskCategory")]
                            [Validation(Required=false)]
                            public List<string> SupportedDataDiskCategory { get; set; }
                        };

                        [NameInMap("InstanceTypes")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypes InstanceTypes { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypes : TeaModel {
                            [NameInMap("supportedInstanceType")]
                            [Validation(Required=false)]
                            public List<string> SupportedInstanceType { get; set; }
                        };

                        [NameInMap("InstanceTypeFamilies")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypeFamilies InstanceTypeFamilies { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoInstanceTypeFamilies : TeaModel {
                            [NameInMap("supportedInstanceTypeFamily")]
                            [Validation(Required=false)]
                            public List<string> SupportedInstanceTypeFamily { get; set; }
                        };

                        [NameInMap("NetworkTypes")]
                        [Validation(Required=false)]
                        public DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoNetworkTypes NetworkTypes { get; set; }
                        public class DescribeZonesResponseBodyZonesZoneAvailableResourcesResourcesInfoNetworkTypes : TeaModel {
                            [NameInMap("supportedNetworkCategory")]
                            [Validation(Required=false)]
                            public List<string> SupportedNetworkCategory { get; set; }
                        };

                    }

                }
                public DescribeZonesResponseBodyZonesZoneAvailableResourceCreation AvailableResourceCreation { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableResourceCreation : TeaModel {
                    [NameInMap("ResourceTypes")]
                    [Validation(Required=false)]
                    public List<string> ResourceTypes { get; set; }

                }
                public DescribeZonesResponseBodyZonesZoneDedicatedHostGenerations DedicatedHostGenerations { get; set; }
                public class DescribeZonesResponseBodyZonesZoneDedicatedHostGenerations : TeaModel {
                    [NameInMap("DedicatedHostGeneration")]
                    [Validation(Required=false)]
                    public List<string> DedicatedHostGeneration { get; set; }

                }
                public DescribeZonesResponseBodyZonesZoneAvailableInstanceTypes AvailableInstanceTypes { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableInstanceTypes : TeaModel {
                    [NameInMap("InstanceTypes")]
                    [Validation(Required=false)]
                    public List<string> InstanceTypes { get; set; }

                }
                public DescribeZonesResponseBodyZonesZoneAvailableDiskCategories AvailableDiskCategories { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableDiskCategories : TeaModel {
                    [NameInMap("DiskCategories")]
                    [Validation(Required=false)]
                    public List<string> DiskCategories { get; set; }

                }
                public DescribeZonesResponseBodyZonesZoneAvailableDedicatedHostTypes AvailableDedicatedHostTypes { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableDedicatedHostTypes : TeaModel {
                    [NameInMap("DedicatedHostType")]
                    [Validation(Required=false)]
                    public List<string> DedicatedHostType { get; set; }

                }
                public DescribeZonesResponseBodyZonesZoneAvailableVolumeCategories AvailableVolumeCategories { get; set; }
                public class DescribeZonesResponseBodyZonesZoneAvailableVolumeCategories : TeaModel {
                    [NameInMap("VolumeCategories")]
                    [Validation(Required=false)]
                    public List<string> VolumeCategories { get; set; }

                }
            }
        };

    }

}
