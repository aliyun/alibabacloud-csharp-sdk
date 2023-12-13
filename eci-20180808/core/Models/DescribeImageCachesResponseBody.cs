// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeImageCachesResponseBody : TeaModel {
        /// <summary>
        /// The information about image caches.
        /// </summary>
        [NameInMap("ImageCaches")]
        [Validation(Required=false)]
        public List<DescribeImageCachesResponseBodyImageCaches> ImageCaches { get; set; }
        public class DescribeImageCachesResponseBodyImageCaches : TeaModel {
            /// <summary>
            /// The ID of the elastic container instance.
            /// </summary>
            [NameInMap("ContainerGroupId")]
            [Validation(Required=false)]
            public string ContainerGroupId { get; set; }

            /// <summary>
            /// The time when the image cache was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The elimination policy of the image cache. This parameter is empty by default, which indicates that the image cache is always retained.
            /// 
            /// You can set this parameter to LRU, which indicates that the image cache can be automatically deleted. When the number of image caches reaches the quota, the system automatically deletes the image caches whose EliminationStrategy parameter is set to LRU and that are least regularly used.
            /// </summary>
            [NameInMap("EliminationStrategy")]
            [Validation(Required=false)]
            public string EliminationStrategy { get; set; }

            /// <summary>
            /// The events of pulling an image to create the image cache.
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<DescribeImageCachesResponseBodyImageCachesEvents> Events { get; set; }
            public class DescribeImageCachesResponseBodyImageCachesEvents : TeaModel {
                /// <summary>
                /// The number of events.
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
                /// The message about the event.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The name of the event.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The cause of the event.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// The type of the event. Valid values:
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The time when the image cache expires.
            /// </summary>
            [NameInMap("ExpireDateTime")]
            [Validation(Required=false)]
            public string ExpireDateTime { get; set; }

            /// <summary>
            /// The ID of the local snapshot. A temporary local snapshot is created if the instant image cache feature is enabled.
            /// </summary>
            [NameInMap("FlashSnapshotId")]
            [Validation(Required=false)]
            public string FlashSnapshotId { get; set; }

            /// <summary>
            /// The ID of the image cache.
            /// </summary>
            [NameInMap("ImageCacheId")]
            [Validation(Required=false)]
            public string ImageCacheId { get; set; }

            /// <summary>
            /// The name of the image cache.
            /// </summary>
            [NameInMap("ImageCacheName")]
            [Validation(Required=false)]
            public string ImageCacheName { get; set; }

            /// <summary>
            /// The size of the image cache. Unit: GiB.
            /// </summary>
            [NameInMap("ImageCacheSize")]
            [Validation(Required=false)]
            public int? ImageCacheSize { get; set; }

            /// <summary>
            /// The images contained in the image cache.
            /// </summary>
            [NameInMap("Images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            /// <summary>
            /// The time when the image cache was last matched.
            /// </summary>
            [NameInMap("LastMatchedTime")]
            [Validation(Required=false)]
            public string LastMatchedTime { get; set; }

            /// <summary>
            /// The progress of creating the snapshot that is used to create the image cache.
            /// 
            /// >  If the instant image cache feature is enabled, the system creates a temporary local snapshot and then a regular snapshot. In this case, this parameter indicates the progress of creating the regular snapshot.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The region ID of the image cache.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group to which the image cache belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The ID of the snapshot that corresponds to the image cache.
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// The status of the image cache. Valid values:
            /// 
            /// *   Preparing: The image cache is being prepared.
            /// *   Creating: The image is being created.
            /// *   Ready: The image cache is created.
            /// *   Failed: The image cache failed to be created.
            /// *   Updating: The image cache is being updated.
            /// *   UpdateFailed: The image cache failed to be updated.
            /// 
            /// The image cache is ready for use when it is in the Ready state.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tags of the image cache.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeImageCachesResponseBodyImageCachesTags> Tags { get; set; }
            public class DescribeImageCachesResponseBodyImageCachesTags : TeaModel {
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
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
