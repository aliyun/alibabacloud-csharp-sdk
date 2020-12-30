// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeFlowReportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FlowReport")]
        [Validation(Required=false)]
        public List<DescribeFlowReportResponseBodyFlowReport> FlowReport { get; set; }
        public class DescribeFlowReportResponseBodyFlowReport : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("ActConns")]
            [Validation(Required=false)]
            public long? ActConns { get; set; }

            [NameInMap("InactConns")]
            [Validation(Required=false)]
            public long? InactConns { get; set; }

            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

        }

    }

}
