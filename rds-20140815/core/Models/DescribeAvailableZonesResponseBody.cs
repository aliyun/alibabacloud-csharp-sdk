// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// The available zones in the region.
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeAvailableZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeAvailableZonesResponseBodyAvailableZones : TeaModel {
            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The database engines that are available for purchase.
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
                /// The database engine versions that are available for purchase.
                /// </summary>
                [NameInMap("SupportedEngineVersions")]
                [Validation(Required=false)]
                public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersions> SupportedEngineVersions { get; set; }
                public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersions : TeaModel {
                    /// <summary>
                    /// The RDS editions that are available that are available for purchase.
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
                        /// The storage types that are available for purchase.
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
                    /// The database engine version.
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// The zone ID.
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
