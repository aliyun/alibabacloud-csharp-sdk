// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableZonesResponseBody : TeaModel {
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeAvailableZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeAvailableZonesResponseBodyAvailableZones : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEngines : TeaModel {
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("SupportedEngineVersions")]
                [Validation(Required=false)]
                public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersions> SupportedEngineVersions { get; set; }
                public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersions : TeaModel {
                    [NameInMap("SupportedCategorys")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorys> SupportedCategorys { get; set; }
                    public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorys : TeaModel {
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        [NameInMap("SupportedStorageTypes")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorysSupportedStorageTypes> SupportedStorageTypes { get; set; }
                        public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorysSupportedStorageTypes : TeaModel {
                            [NameInMap("StorageType")]
                            [Validation(Required=false)]
                            public string StorageType { get; set; }

                        }

                    }

                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
