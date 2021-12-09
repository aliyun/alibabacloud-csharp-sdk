// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetServiceResponseBody : TeaModel {
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public GetServiceResponseBodyBuckets Buckets { get; set; }
        public class GetServiceResponseBodyBuckets : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public List<string> Buckets { get; set; }
        };

        [NameInMap("Owner")]
        [Validation(Required=false)]
        public Owner Owner { get; set; }

    }

}
