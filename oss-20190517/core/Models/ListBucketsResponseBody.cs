// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ListBucketsResponseBody : TeaModel {
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public ListBucketsResponseBodyBuckets Buckets { get; set; }
        public class ListBucketsResponseBodyBuckets : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public List<string> Buckets { get; set; }
        };

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

    }

}
