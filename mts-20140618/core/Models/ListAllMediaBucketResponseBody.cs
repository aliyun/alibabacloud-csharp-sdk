// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListAllMediaBucketResponseBody : TeaModel {
        /// <summary>
        /// The media buckets returned.
        /// </summary>
        [NameInMap("MediaBucketList")]
        [Validation(Required=false)]
        public ListAllMediaBucketResponseBodyMediaBucketList MediaBucketList { get; set; }
        public class ListAllMediaBucketResponseBodyMediaBucketList : TeaModel {
            [NameInMap("MediaBucket")]
            [Validation(Required=false)]
            public List<ListAllMediaBucketResponseBodyMediaBucketListMediaBucket> MediaBucket { get; set; }
            public class ListAllMediaBucketResponseBodyMediaBucketListMediaBucket : TeaModel {
                /// <summary>
                /// The name of the media bucket.
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// The settings of Object Storage Service (OSS) hotlink protection. For more information, see [Hotlink protection](https://help.aliyun.com/document_detail/31869.html).
                /// </summary>
                [NameInMap("Referer")]
                [Validation(Required=false)]
                public string Referer { get; set; }

                /// <summary>
                /// The type of the media bucket. Valid values:
                /// 
                /// *   Input: input media bucket
                /// *   Output: output media bucket
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The returned value of NextPageToken is a pagination token, which can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
