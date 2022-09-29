// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeFirstRankResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeFirstRankResponseBodyResult Result { get; set; }
        public class DescribeFirstRankResponseBodyResult : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("meta")]
            [Validation(Required=false)]
            public List<DescribeFirstRankResponseBodyResultMeta> Meta { get; set; }
            public class DescribeFirstRankResponseBodyResultMeta : TeaModel {
                [NameInMap("arg")]
                [Validation(Required=false)]
                public string Arg { get; set; }

                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                [NameInMap("weight")]
                [Validation(Required=false)]
                public float? Weight { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
