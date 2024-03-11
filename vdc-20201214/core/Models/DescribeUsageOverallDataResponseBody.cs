// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeUsageOverallDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageOverallData")]
        [Validation(Required=false)]
        public List<DescribeUsageOverallDataResponseBodyUsageOverallData> UsageOverallData { get; set; }
        public class DescribeUsageOverallDataResponseBodyUsageOverallData : TeaModel {
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeUsageOverallDataResponseBodyUsageOverallDataNodes> Nodes { get; set; }
            public class DescribeUsageOverallDataResponseBodyUsageOverallDataNodes : TeaModel {
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
