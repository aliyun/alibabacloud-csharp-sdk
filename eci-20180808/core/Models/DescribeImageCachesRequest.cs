// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeImageCachesRequest : TeaModel {
        /// <summary>
        /// The container images.
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// The IDs of the image caches.
        /// </summary>
        [NameInMap("ImageCacheId")]
        [Validation(Required=false)]
        public string ImageCacheId { get; set; }

        /// <summary>
        /// The names of the image caches.
        /// </summary>
        [NameInMap("ImageCacheName")]
        [Validation(Required=false)]
        public string ImageCacheName { get; set; }

        /// <summary>
        /// Specifies whether the image layers of the image caches must contain all image layers of the container image.\
        /// If you configure MatchImage, you can configure this parameter to further filter query results.
        /// </summary>
        [NameInMap("ImageFullMatch")]
        [Validation(Required=false)]
        public bool? ImageFullMatch { get; set; }

        /// <summary>
        /// The quantity of image caches whose image layers contain all image layers of the container image.\
        /// If you configure MatchImage, you can configure this parameter to further filter query results.
        /// </summary>
        [NameInMap("ImageMatchCountRequest")]
        [Validation(Required=false)]
        public int? ImageMatchCountRequest { get; set; }

        /// <summary>
        /// The maximum entries of query results that are allowed to be displayed.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The container images used to match the image caches that you want to query. You can specify a maximum of 100 container images.
        /// </summary>
        [NameInMap("MatchImage")]
        [Validation(Required=false)]
        public List<string> MatchImage { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the image caches.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the image caches belong.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The IDs of the snapshots that correspond to the image caches.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The tags to add to the image caches.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImageCachesRequestTag> Tag { get; set; }
        public class DescribeImageCachesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the image cache.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the image cache.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
