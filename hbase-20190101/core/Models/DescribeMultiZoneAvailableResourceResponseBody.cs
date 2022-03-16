// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeMultiZoneAvailableResourceResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZone : TeaModel {
                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResources MasterResources { get; set; }
                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResources : TeaModel {
                    [NameInMap("MasterResource")]
                    [Validation(Required=false)]
                    public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResource> MasterResource { get; set; }
                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResource : TeaModel {
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("InstanceTypeDetail")]
                        [Validation(Required=false)]
                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResourceInstanceTypeDetail InstanceTypeDetail { get; set; }
                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResourceInstanceTypeDetail : TeaModel {
                            [NameInMap("Cpu")]
                            [Validation(Required=false)]
                            public int? Cpu { get; set; }
                            [NameInMap("Mem")]
                            [Validation(Required=false)]
                            public int? Mem { get; set; }
                        };

                    }

                }
                public string RegionId { get; set; }
                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines SupportedEngines { get; set; }
                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines : TeaModel {
                    [NameInMap("SupportedEngine")]
                    [Validation(Required=false)]
                    public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine> SupportedEngine { get; set; }
                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine : TeaModel {
                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        [NameInMap("SupportedEngineVersions")]
                        [Validation(Required=false)]
                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersions SupportedEngineVersions { get; set; }
                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersions : TeaModel {
                            [NameInMap("SupportedEngineVersion")]
                            [Validation(Required=false)]
                            public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                            public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories SupportedCategories { get; set; }
                                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories : TeaModel {
                                    [NameInMap("SupportedCategories")]
                                    [Validation(Required=false)]
                                    public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories> SupportedCategories { get; set; }
                                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories : TeaModel {
                                        [NameInMap("Category")]
                                        [Validation(Required=false)]
                                        public string Category { get; set; }

                                        [NameInMap("SupportedStorageTypes")]
                                        [Validation(Required=false)]
                                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes SupportedStorageTypes { get; set; }
                                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes : TeaModel {
                                            [NameInMap("SupportedStorageType")]
                                            [Validation(Required=false)]
                                            public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType> SupportedStorageType { get; set; }
                                            public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType : TeaModel {
                                                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResources CoreResources { get; set; }
                                                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResources : TeaModel {
                                                    [NameInMap("CoreResource")]
                                                    [Validation(Required=false)]
                                                    public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResource> CoreResource { get; set; }
                                                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResource : TeaModel {
                                                        [NameInMap("DBInstanceStorageRange")]
                                                        [Validation(Required=false)]
                                                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceDBInstanceStorageRange DBInstanceStorageRange { get; set; }
                                                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceDBInstanceStorageRange : TeaModel {
                                                            [NameInMap("MaxSize")]
                                                            [Validation(Required=false)]
                                                            public int? MaxSize { get; set; }
                                                            [NameInMap("MinSize")]
                                                            [Validation(Required=false)]
                                                            public int? MinSize { get; set; }
                                                            [NameInMap("StepSize")]
                                                            [Validation(Required=false)]
                                                            public int? StepSize { get; set; }
                                                        };

                                                        [NameInMap("InstanceType")]
                                                        [Validation(Required=false)]
                                                        public string InstanceType { get; set; }

                                                        [NameInMap("InstanceTypeDetail")]
                                                        [Validation(Required=false)]
                                                        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceInstanceTypeDetail InstanceTypeDetail { get; set; }
                                                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceInstanceTypeDetail : TeaModel {
                                                            [NameInMap("Cpu")]
                                                            [Validation(Required=false)]
                                                            public int? Cpu { get; set; }
                                                            [NameInMap("Mem")]
                                                            [Validation(Required=false)]
                                                            public int? Mem { get; set; }
                                                        };

                                                        [NameInMap("MaxCoreCount")]
                                                        [Validation(Required=false)]
                                                        public int? MaxCoreCount { get; set; }

                                                    }

                                                }
                                                public string StorageType { get; set; }
                                            }
                                        };

                                    }

                                }
                                public string Version { get; set; }
                            }
                        };

                    }

                }
                public string ZoneCombination { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
