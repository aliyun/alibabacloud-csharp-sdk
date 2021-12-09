// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetBucketWebsiteResponseBody : TeaModel {
        [NameInMap("ErrorDocument")]
        [Validation(Required=false)]
        public GetBucketWebsiteResponseBodyErrorDocument ErrorDocument { get; set; }
        public class GetBucketWebsiteResponseBodyErrorDocument : TeaModel {
            [NameInMap("HttpStatus")]
            [Validation(Required=false)]
            public string HttpStatus { get; set; }
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
        };

        [NameInMap("IndexDocument")]
        [Validation(Required=false)]
        public GetBucketWebsiteResponseBodyIndexDocument IndexDocument { get; set; }
        public class GetBucketWebsiteResponseBodyIndexDocument : TeaModel {
            [NameInMap("Suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }
        };

        [NameInMap("RoutingRules")]
        [Validation(Required=false)]
        public GetBucketWebsiteResponseBodyRoutingRules RoutingRules { get; set; }
        public class GetBucketWebsiteResponseBodyRoutingRules : TeaModel {
            [NameInMap("RoutingRule")]
            [Validation(Required=false)]
            public List<string> RoutingRules { get; set; }
        };

    }

}
