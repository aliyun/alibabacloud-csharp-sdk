// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ListAllMediaBucketResponseBody : TeaModel {
        [NameInMap("MediaBucketList")]
        [Validation(Required=false)]
        public ListAllMediaBucketResponseBodyMediaBucketList MediaBucketList { get; set; }
        public class ListAllMediaBucketResponseBodyMediaBucketList : TeaModel {
            [NameInMap("MediaBucket")]
            [Validation(Required=false)]
            public List<ListAllMediaBucketResponseBodyMediaBucketListMediaBucket> MediaBucket { get; set; }
            public class ListAllMediaBucketResponseBodyMediaBucketListMediaBucket : TeaModel {
                public string Bucket { get; set; }
                public string Referer { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
