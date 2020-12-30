// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeSourceFailureTrendGraphResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TrendGraph")]
        [Validation(Required=false)]
        public List<DescribeSourceFailureTrendGraphResponseBodyTrendGraph> TrendGraph { get; set; }
        public class DescribeSourceFailureTrendGraphResponseBodyTrendGraph : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

    }

}
