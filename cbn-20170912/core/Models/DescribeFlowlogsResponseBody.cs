// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeFlowlogsResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("FlowLogs")]
        [Validation(Required=false)]
        public DescribeFlowlogsResponseBodyFlowLogs FlowLogs { get; set; }
        public class DescribeFlowlogsResponseBodyFlowLogs : TeaModel {
            [NameInMap("FlowLog")]
            [Validation(Required=false)]
            public List<DescribeFlowlogsResponseBodyFlowLogsFlowLog> FlowLog { get; set; }
            public class DescribeFlowlogsResponseBodyFlowLogsFlowLog : TeaModel {
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string FlowLogName { get; set; }
                public string Description { get; set; }
                public string ProjectName { get; set; }
                public string CenId { get; set; }
                public string LogStoreName { get; set; }
                public string RegionId { get; set; }
                public string FlowLogId { get; set; }
            }
        };

    }

}
