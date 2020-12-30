// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFlowLogsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("FlowLogs")]
        [Validation(Required=false)]
        public DescribeFlowLogsResponseBodyFlowLogs FlowLogs { get; set; }
        public class DescribeFlowLogsResponseBodyFlowLogs : TeaModel {
            [NameInMap("FlowLog")]
            [Validation(Required=false)]
            public List<DescribeFlowLogsResponseBodyFlowLogsFlowLog> FlowLog { get; set; }
            public class DescribeFlowLogsResponseBodyFlowLogsFlowLog : TeaModel {
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string FlowLogName { get; set; }
                public string TrafficType { get; set; }
                public string ResourceType { get; set; }
                public string Description { get; set; }
                public string ProjectName { get; set; }
                public string LogStoreName { get; set; }
                public string ResourceId { get; set; }
                public string RegionId { get; set; }
                public string FlowLogId { get; set; }
            }
        };

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
