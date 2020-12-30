// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeMultiZoneAvailableResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeMultiZoneAvailableResourceResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZone : TeaModel {
                [NameInMap("SupportedEngine")]
                [Validation(Required=false)]
                public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngine> SupportedEngine { get; set; }
                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngine : TeaModel {
                    [NameInMap("SupportedEngineVersions")]
                    [Validation(Required=false)]
                    public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersions SupportedEngineVersions { get; set; }
                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersions : TeaModel {
                        [NameInMap("SupportedEngineVersion")]
                        [Validation(Required=false)]
                        public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                            public string Version { get; set; }
                            public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories SupportedCategories { get; set; }
                            public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories : TeaModel {
                                [NameInMap("SupportedCategories")]
                                [Validation(Required=false)]
                                public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories> SupportedCategories { get; set; }
                                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories : TeaModel {
                                    [NameInMap("SupportedStorageTypes")]
                                    [Validation(Required=false)]
                                    public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes SupportedStorageTypes { get; set; }
                                    public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes : TeaModel {
                                        [NameInMap("SupportedStorageType")]
                                        [Validation(Required=false)]
                                        public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType> SupportedStorageType { get; set; }
                                        public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType : TeaModel {
                                            [NameInMap("CoreResource")]
                                            [Validation(Required=false)]
                                            public List<DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResource> CoreResource { get; set; }
                                            public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResource : TeaModel {
                                                [NameInMap("InstanceTypeDetail")]
                                                [Validation(Required=false)]
                                                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourceInstanceTypeDetail InstanceTypeDetail { get; set; }
                                                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourceInstanceTypeDetail : TeaModel {
                                                    [NameInMap("Cpu")]
                                                    [Validation(Required=false)]
                                                    public int? Cpu { get; set; }
                                                    [NameInMap("Mem")]
                                                    [Validation(Required=false)]
                                                    public int? Mem { get; set; }
                                                };

                                                [NameInMap("DBInstanceStorageRange")]
                                                [Validation(Required=false)]
                                                public DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourceDBInstanceStorageRange DBInstanceStorageRange { get; set; }
                                                public class DescribeMultiZoneAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourceDBInstanceStorageRange : TeaModel {
                                                    [NameInMap("MaxSize")]
                                                    [Validation(Required=false)]
                                                    public int? MaxSize { get; set; }
                                                    [NameInMap("StepSize")]
                                                    [Validation(Required=false)]
                                                    public int? StepSize { get; set; }
                                                    [NameInMap("MinSize")]
                                                    [Validation(Required=false)]
                                                    public int? MinSize { get; set; }
                                                };

                                                [NameInMap("MaxCoreCount")]
                                                [Validation(Required=false)]
                                                public int? MaxCoreCount { get; set; }

                                                [NameInMap("InstanceType")]
                                                [Validation(Required=false)]
                                                public string InstanceType { get; set; }

                                            }

                                        }
                                    };

                                    [NameInMap("Category")]
                                    [Validation(Required=false)]
                                    public string Category { get; set; }

                                }

                            }
                        }
                    };

                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                }

            }
        };

    }

}
