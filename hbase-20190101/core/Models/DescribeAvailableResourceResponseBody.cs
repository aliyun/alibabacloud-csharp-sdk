// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyAvailableZones AvailableZones { get; set; }
        public class DescribeAvailableResourceResponseBodyAvailableZones : TeaModel {
            [NameInMap("AvailableZone")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone> AvailableZone { get; set; }
            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZone : TeaModel {
                [NameInMap("SupportedEngine")]
                [Validation(Required=false)]
                public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngine> SupportedEngine { get; set; }
                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngine : TeaModel {
                    [NameInMap("SupportedEngineVersions")]
                    [Validation(Required=false)]
                    public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersions SupportedEngineVersions { get; set; }
                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersions : TeaModel {
                        [NameInMap("SupportedEngineVersion")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersion> SupportedEngineVersion { get; set; }
                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersion : TeaModel {
                            public string Version { get; set; }
                            public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories SupportedCategories { get; set; }
                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategories : TeaModel {
                                [NameInMap("SupportedCategories")]
                                [Validation(Required=false)]
                                public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories> SupportedCategories { get; set; }
                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategories : TeaModel {
                                    [NameInMap("SupportedStorageTypes")]
                                    [Validation(Required=false)]
                                    public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes SupportedStorageTypes { get; set; }
                                    public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypes : TeaModel {
                                        [NameInMap("SupportedStorageType")]
                                        [Validation(Required=false)]
                                        public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType> SupportedStorageType { get; set; }
                                        public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageType : TeaModel {
                                            [NameInMap("CoreResource")]
                                            [Validation(Required=false)]
                                            public List<DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResource> CoreResource { get; set; }
                                            public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResource : TeaModel {
                                                [NameInMap("InstanceTypeDetail")]
                                                [Validation(Required=false)]
                                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourceInstanceTypeDetail InstanceTypeDetail { get; set; }
                                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourceInstanceTypeDetail : TeaModel {
                                                    [NameInMap("Cpu")]
                                                    [Validation(Required=false)]
                                                    public int? Cpu { get; set; }
                                                    [NameInMap("Mem")]
                                                    [Validation(Required=false)]
                                                    public int? Mem { get; set; }
                                                };

                                                [NameInMap("DBInstanceStorageRange")]
                                                [Validation(Required=false)]
                                                public DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourceDBInstanceStorageRange DBInstanceStorageRange { get; set; }
                                                public class DescribeAvailableResourceResponseBodyAvailableZonesAvailableZoneSupportedEngineSupportedEngineVersionsSupportedEngineVersionSupportedCategoriesSupportedCategoriesSupportedStorageTypesSupportedStorageTypeCoreResourceDBInstanceStorageRange : TeaModel {
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
