// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of available zones and resources available in the zones.
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeAvailableZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeAvailableZonesResponseBodyAvailableZones : TeaModel {
            /// <summary>
            /// The region ID of the instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// An array that consists of the database engines available in the zone.
            /// </summary>
            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEngines : TeaModel {
                /// <summary>
                /// The database engine of the instance.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// An array that consists of the database engine versions available in the zone.
                /// </summary>
                [NameInMap("SupportedEngineVersions")]
                [Validation(Required=false)]
                public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersions> SupportedEngineVersions { get; set; }
                public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersions : TeaModel {
                    /// <summary>
                    /// An array that consists of the RDS editions available in the zone.
                    /// </summary>
                    [NameInMap("SupportedCategorys")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorys> SupportedCategorys { get; set; }
                    public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorys : TeaModel {
                        /// <summary>
                        /// The RDS edition of the instance.
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// An array that consists of the storage types available in the zone.
                        /// </summary>
                        [NameInMap("SupportedStorageTypes")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorysSupportedStorageTypes> SupportedStorageTypes { get; set; }
                        public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorysSupportedStorageTypes : TeaModel {
                            /// <summary>
                            /// The storage type of the instance.
                            /// </summary>
                            [NameInMap("StorageType")]
                            [Validation(Required=false)]
                            public string StorageType { get; set; }

                        }

                    }

                    /// <summary>
                    /// The database engine version of the instance.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// The zone ID of the instance.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
