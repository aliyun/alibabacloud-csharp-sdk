// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeLayer7CCRulesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long? Total { get; set; }

        [NameInMap("Layer7CCRules")]
        [Validation(Required=true)]
        public List<DescribeLayer7CCRulesResponseLayer7CCRules> Layer7CCRules { get; set; }
        public class DescribeLayer7CCRulesResponseLayer7CCRules : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Act")]
            [Validation(Required=true)]
            public string Act { get; set; }

            [NameInMap("Count")]
            [Validation(Required=true)]
            public int? Count { get; set; }

            [NameInMap("Interval")]
            [Validation(Required=true)]
            public int? Interval { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=true)]
            public string Mode { get; set; }

            [NameInMap("Ttl")]
            [Validation(Required=true)]
            public int? Ttl { get; set; }

            [NameInMap("Uri")]
            [Validation(Required=true)]
            public string Uri { get; set; }

        }

    }

}
