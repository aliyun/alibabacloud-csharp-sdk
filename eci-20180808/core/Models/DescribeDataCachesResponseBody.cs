// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeDataCachesResponseBody : TeaModel {
        /// <summary>
        /// The information about the data caches.
        /// </summary>
        [NameInMap("DataCaches")]
        [Validation(Required=false)]
        public List<DescribeDataCachesResponseBodyDataCaches> DataCaches { get; set; }
        public class DescribeDataCachesResponseBodyDataCaches : TeaModel {
            /// <summary>
            /// The bucket that stores the data cache.
            /// </summary>
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// The ID of the elastic container instance that was generated when the data cache was created.
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// The time when the data cache was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The data cache ID.
            /// </summary>
            [NameInMap("DataCacheId")]
            [Validation(Required=false)]
            public string DataCacheId { get; set; }

            /// <summary>
            /// The information about the data source.
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public DescribeDataCachesResponseBodyDataCachesDataSource DataSource { get; set; }
            public class DescribeDataCachesResponseBodyDataCachesDataSource : TeaModel {
                /// <summary>
                /// The parameters that are configured for the data source.
                /// </summary>
                [NameInMap("Options")]
                [Validation(Required=false)]
                public string Options { get; set; }

                /// <summary>
                /// The type of the data source. Valid values:
                /// 
                /// *   NAS
                /// *   OSS
                /// *   URL
                /// *   SNAPSHOT
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The events.
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeDataCachesResponseBodyDataCachesEvents> Events { get; set; }
            public class DescribeDataCachesResponseBodyDataCachesEvents : TeaModel {
                /// <summary>
                /// The number of times that the event occurred.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The time when the event started.
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// The time when the event ended.
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// The information about the event.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The event name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The event cause.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// The event type. Valid values:
                /// 
                /// *   Normal
                /// *   Warning
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The time when the data cache expires.
            /// </summary>
            [NameInMap("ExpireDateTime")]
            [Validation(Required=false)]
            public string ExpireDateTime { get; set; }

            /// <summary>
            /// The ID of the local snapshot.
            /// </summary>
            [NameInMap("FlashSnapshotId")]
            [Validation(Required=false)]
            public string FlashSnapshotId { get; set; }

            /// <summary>
            /// The time when the data cache was last matched.
            /// </summary>
            [NameInMap("LastMatchedTime")]
            [Validation(Required=false)]
            public string LastMatchedTime { get; set; }

            /// <summary>
            /// The data cache name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The vHost directory in which the data cache resides.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The creation progress of the data cache.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The size of the data cache. Unit: GiB.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// The snapshot ID.
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// The state of the data cache. Valid values:
            /// 
            /// *   Loading: The data cache is loading data.
            /// *   Creating: The data cache is being created.
            /// *   Available: The data cache is created.
            /// *   Failed: The data cache failed to be created.
            /// *   Updating: The data cache is being updated.
            /// *   UpdateFailed: The data cache failed to be updated.
            /// 
            /// The data cache is available when it is in the Ready state.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags that are attached to the data cache.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDataCachesResponseBodyDataCachesTags> Tags { get; set; }
            public class DescribeDataCachesResponseBodyDataCachesTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The query token. Set the value to the NextToken value that is returned in the previous call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
