// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class ListDatasourceFeatureViewsResponseBody : TeaModel {
        [NameInMap("FeatureViews")]
        [Validation(Required=false)]
        public List<ListDatasourceFeatureViewsResponseBodyFeatureViews> FeatureViews { get; set; }
        public class ListDatasourceFeatureViewsResponseBodyFeatureViews : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;shard_count&quot;:5,&quot;replication_count&quot;:1}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("FeatureEntityName")]
            [Validation(Required=false)]
            public string FeatureEntityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("FeatureViewId")]
            [Validation(Required=false)]
            public string FeatureViewId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fv1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>p1</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("TTL")]
            [Validation(Required=false)]
            public int? TTL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Batch</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UsageStatistics")]
            [Validation(Required=false)]
            public ListDatasourceFeatureViewsResponseBodyFeatureViewsUsageStatistics UsageStatistics { get; set; }
            public class ListDatasourceFeatureViewsResponseBodyFeatureViewsUsageStatistics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1.23</para>
                /// </summary>
                [NameInMap("DiskUsage")]
                [Validation(Required=false)]
                public double? DiskUsage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("MemoryUsage")]
                [Validation(Required=false)]
                public double? MemoryUsage { get; set; }

                [NameInMap("ReadWriteCount")]
                [Validation(Required=false)]
                public List<ListDatasourceFeatureViewsResponseBodyFeatureViewsUsageStatisticsReadWriteCount> ReadWriteCount { get; set; }
                public class ListDatasourceFeatureViewsResponseBodyFeatureViewsUsageStatisticsReadWriteCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-03-18T00:00:00+08:00</para>
                    /// </summary>
                    [NameInMap("Date")]
                    [Validation(Required=false)]
                    public string Date { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("ReadCount")]
                    [Validation(Required=false)]
                    public long? ReadCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("WriteCount")]
                    [Validation(Required=false)]
                    public long? WriteCount { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("RowCount")]
                [Validation(Required=false)]
                public long? RowCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TotalUsageStatistics")]
        [Validation(Required=false)]
        public ListDatasourceFeatureViewsResponseBodyTotalUsageStatistics TotalUsageStatistics { get; set; }
        public class ListDatasourceFeatureViewsResponseBodyTotalUsageStatistics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>12.3</para>
            /// </summary>
            [NameInMap("TotalDiskUsage")]
            [Validation(Required=false)]
            public double? TotalDiskUsage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.23</para>
            /// </summary>
            [NameInMap("TotalMemoryUsage")]
            [Validation(Required=false)]
            public double? TotalMemoryUsage { get; set; }

            [NameInMap("TotalReadWriteCount")]
            [Validation(Required=false)]
            public List<ListDatasourceFeatureViewsResponseBodyTotalUsageStatisticsTotalReadWriteCount> TotalReadWriteCount { get; set; }
            public class ListDatasourceFeatureViewsResponseBodyTotalUsageStatisticsTotalReadWriteCount : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-18T00:00:00+08:00</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>456</para>
                /// </summary>
                [NameInMap("TotalReadCount")]
                [Validation(Required=false)]
                public long? TotalReadCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("TotalWriteCount")]
                [Validation(Required=false)]
                public long? TotalWriteCount { get; set; }

            }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>514F82AF-3C04-5C3D-8F38-A11261BF37B0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
