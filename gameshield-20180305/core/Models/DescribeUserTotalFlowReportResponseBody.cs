// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeUserTotalFlowReportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PromptInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> PromptInfo { get; set; }

        [NameInMap("FlowReport")]
        [Validation(Required=false)]
        public DescribeUserTotalFlowReportResponseBodyFlowReport FlowReport { get; set; }
        public class DescribeUserTotalFlowReportResponseBodyFlowReport : TeaModel {
            [NameInMap("Time")]
            [Validation(Required=false)]
            public List<string> Time { get; set; }
            [NameInMap("MaxInflow")]
            [Validation(Required=false)]
            public List<string> MaxInflow { get; set; }
            [NameInMap("AttackFlow")]
            [Validation(Required=false)]
            public List<string> AttackFlow { get; set; }
            [NameInMap("MaxOutFlow")]
            [Validation(Required=false)]
            public List<string> MaxOutFlow { get; set; }
        };

    }

}
