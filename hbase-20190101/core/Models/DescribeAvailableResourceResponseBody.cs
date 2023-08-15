// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone : TeaModel {
                [NameInMap("MasterResources")]
                [Validation(Required=false)]
                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResources MasterResources { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResources : TeaModel {
                    [NameInMap("MasterResource")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResource> MasterResource { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResource : TeaModel {
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("InstanceTypeDetail")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResourceInstanceTypeDetail InstanceTypeDetail { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneMasterResourcesMasterResourceInstanceTypeDetail : TeaModel {
                            [NameInMap("Cpu")]
                            [Validation(Required=false)]
                            public int? Cpu { get; set; }

                            [NameInMap("Mem")]
                            [Validation(Required=false)]
                            public int? Mem { get; set; }

                        }

                    }

                }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SupportedEngines")]
                [Validation(Required=false)]
                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines SupportedEngines { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngines : TeaModel {
                    [NameInMap("SupportedEngine")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine> SupportedEngine { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngine : TeaModel {
                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        [NameInMap("SupportedEngineVersions")]
                        [Validation(Required=false)]
                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersions SupportedEngineVersions { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersions : TeaModel {
                            [NameInMap("SupportedEngineVersion")]
                            [Validation(Required=false)]
                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                                [NameInMap("SupportedCategories")]
                                [Validation(Required=false)]
                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories SupportedCategories { get; set; }
                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories : TeaModel {
                                    [NameInMap("SupportedCategories")]
                                    [Validation(Required=false)]
                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories> SupportedCategories { get; set; }
                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories : TeaModel {
                                        [NameInMap("Category")]
                                        [Validation(Required=false)]
                                        public string Category { get; set; }

                                        [NameInMap("SupportedStorageTypes")]
                                        [Validation(Required=false)]
                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes SupportedStorageTypes { get; set; }
                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes : TeaModel {
                                            [NameInMap("SupportedStorageType")]
                                            [Validation(Required=false)]
                                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType> SupportedStorageType { get; set; }
                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType : TeaModel {
                                                [NameInMap("CoreResources")]
                                                [Validation(Required=false)]
                                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResources CoreResources { get; set; }
                                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResources : TeaModel {
                                                    [NameInMap("CoreResource")]
                                                    [Validation(Required=false)]
                                                    public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResource> CoreResource { get; set; }
                                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResource : TeaModel {
                                                        [NameInMap("DBInstanceStorageRange")]
                                                        [Validation(Required=false)]
                                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceDBInstanceStorageRange DBInstanceStorageRange { get; set; }
                                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceDBInstanceStorageRange : TeaModel {
                                                            [NameInMap("MaxSize")]
                                                            [Validation(Required=false)]
                                                            public int? MaxSize { get; set; }

                                                            [NameInMap("MinSize")]
                                                            [Validation(Required=false)]
                                                            public int? MinSize { get; set; }

                                                            [NameInMap("StepSize")]
                                                            [Validation(Required=false)]
                                                            public int? StepSize { get; set; }

                                                        }

                                                        [NameInMap("InstanceType")]
                                                        [Validation(Required=false)]
                                                        public string InstanceType { get; set; }

                                                        [NameInMap("InstanceTypeDetail")]
                                                        [Validation(Required=false)]
                                                        public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceInstanceTypeDetail InstanceTypeDetail { get; set; }
                                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEnginesSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourcesCoreResourceInstanceTypeDetail : TeaModel {
                                                            [NameInMap("Cpu")]
                                                            [Validation(Required=false)]
                                                            public int? Cpu { get; set; }

                                                            [NameInMap("Mem")]
                                                            [Validation(Required=false)]
                                                            public int? Mem { get; set; }

                                                        }

                                                        [NameInMap("MaxCoreCount")]
                                                        [Validation(Required=false)]
                                                        public int? MaxCoreCount { get; set; }

                                                    }

                                                }

                                                [NameInMap("StorageType")]
                                                [Validation(Required=false)]
                                                public string StorageType { get; set; }

                                            }

                                        }

                                    }

                                }

                                [NameInMap("Version")]
                                [Validation(Required=false)]
                                public string Version { get; set; }

                            }

                        }

                    }

                }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
