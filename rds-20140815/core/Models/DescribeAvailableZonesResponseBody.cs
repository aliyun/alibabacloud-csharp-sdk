// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableZonesResponseBody : TeaModel {
        /// <summary>
        /// <para>The available zones in the region.</para>
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<DescribeAvailableZonesResponseBodyAvailableZones> AvailableZones { get; set; }
        public class DescribeAvailableZonesResponseBodyAvailableZones : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The database engines that are available for purchase.</para>
            /// </summary>
            [NameInMap("SupportedEngines")]
            [Validation(Required=false)]
            public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEngines> SupportedEngines { get; set; }
            public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEngines : TeaModel {
                /// <summary>
                /// <para>The database engine of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine versions that are available for purchase.</para>
                /// </summary>
                [NameInMap("SupportedEngineVersions")]
                [Validation(Required=false)]
                public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersions> SupportedEngineVersions { get; set; }
                public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersions : TeaModel {
                    /// <summary>
                    /// <para>The RDS editions that are available that are available for purchase.</para>
                    /// </summary>
                    [NameInMap("SupportedCategorys")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorys> SupportedCategorys { get; set; }
                    public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorys : TeaModel {
                        /// <summary>
                        /// <para>The RDS edition of the instance.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HighAvailability</para>
                        /// </summary>
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public string Category { get; set; }

                        /// <summary>
                        /// <para>The storage types that are available for purchase.</para>
                        /// </summary>
                        [NameInMap("SupportedStorageTypes")]
                        [Validation(Required=false)]
                        public List<DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorysSupportedStorageTypes> SupportedStorageTypes { get; set; }
                        public class DescribeAvailableZonesResponseBodyAvailableZonesSupportedEnginesSupportedEngineVersionsSupportedCategorysSupportedStorageTypes : TeaModel {
                            /// <summary>
                            /// <para>The storage type of the instance.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>local_ssd</para>
                            /// </summary>
                            [NameInMap("StorageType")]
                            [Validation(Required=false)]
                            public string StorageType { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The database engine version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8.0</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

            }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-e</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4256E149-C3C4-4FA7-BDEA-13CA415E8763</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
