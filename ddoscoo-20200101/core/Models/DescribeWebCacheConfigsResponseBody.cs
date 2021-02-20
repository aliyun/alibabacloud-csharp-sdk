// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCacheConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainCacheConfigs")]
        [Validation(Required=false)]
        public List<DescribeWebCacheConfigsResponseBodyDomainCacheConfigs> DomainCacheConfigs { get; set; }
        public class DescribeWebCacheConfigsResponseBodyDomainCacheConfigs : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("CustomRules")]
            [Validation(Required=false)]
            public List<DescribeWebCacheConfigsResponseBodyDomainCacheConfigsCustomRules> CustomRules { get; set; }
            public class DescribeWebCacheConfigsResponseBodyDomainCacheConfigsCustomRules : TeaModel {
                [NameInMap("CacheTtl")]
                [Validation(Required=false)]
                public long? CacheTtl { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

        }

    }

}
