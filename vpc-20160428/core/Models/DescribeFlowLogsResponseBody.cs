// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFlowLogsResponseBody : TeaModel {
        [NameInMap("FlowLogs")]
        [Validation(Required=false)]
        public DescribeFlowLogsResponseBodyFlowLogs FlowLogs { get; set; }
        public class DescribeFlowLogsResponseBodyFlowLogs : TeaModel {
            [NameInMap("FlowLog")]
            [Validation(Required=false)]
            public List<DescribeFlowLogsResponseBodyFlowLogsFlowLog> FlowLog { get; set; }
            public class DescribeFlowLogsResponseBodyFlowLogsFlowLog : TeaModel {
                [NameInMap("AggregationInterval")]
                [Validation(Required=false)]
                public int? AggregationInterval { get; set; }

                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FlowLogId")]
                [Validation(Required=false)]
                public string FlowLogId { get; set; }

                [NameInMap("FlowLogName")]
                [Validation(Required=false)]
                public string FlowLogName { get; set; }

                [NameInMap("LogStoreName")]
                [Validation(Required=false)]
                public string LogStoreName { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TrafficType")]
                [Validation(Required=false)]
                public string TrafficType { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
