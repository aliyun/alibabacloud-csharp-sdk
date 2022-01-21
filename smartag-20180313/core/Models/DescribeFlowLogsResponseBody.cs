// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeFlowLogsResponseBody : TeaModel {
        [NameInMap("FlowLogs")]
        [Validation(Required=false)]
        public DescribeFlowLogsResponseBodyFlowLogs FlowLogs { get; set; }
        public class DescribeFlowLogsResponseBodyFlowLogs : TeaModel {
            [NameInMap("FlowLogSetType")]
            [Validation(Required=false)]
            public List<DescribeFlowLogsResponseBodyFlowLogsFlowLogSetType> FlowLogSetType { get; set; }
            public class DescribeFlowLogsResponseBodyFlowLogsFlowLogSetType : TeaModel {
                public int? ActiveAging { get; set; }
                public string Description { get; set; }
                public string FlowLogId { get; set; }
                public int? InactiveAging { get; set; }
                public string LogstoreName { get; set; }
                public string Name { get; set; }
                public string NetflowServerIp { get; set; }
                public string NetflowServerPort { get; set; }
                public string NetflowVersion { get; set; }
                public string OutputType { get; set; }
                public string ProjectName { get; set; }
                public string ResourceGroupId { get; set; }
                public string SlsRegionId { get; set; }
                public string Status { get; set; }
                public int? TotalSagNum { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
