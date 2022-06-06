// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFlowStatisticResponseBody : TeaModel {
        [NameInMap("DesktopCount")]
        [Validation(Required=false)]
        public int? DesktopCount { get; set; }

        [NameInMap("DesktopFlowStatistic")]
        [Validation(Required=false)]
        public List<DescribeFlowStatisticResponseBodyDesktopFlowStatistic> DesktopFlowStatistic { get; set; }
        public class DescribeFlowStatisticResponseBodyDesktopFlowStatistic : TeaModel {
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("FlowIn")]
            [Validation(Required=false)]
            public string FlowIn { get; set; }

            [NameInMap("FlowRank")]
            [Validation(Required=false)]
            public int? FlowRank { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
