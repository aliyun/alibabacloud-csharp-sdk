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
                [NameInMap("ActiveAging")]
                [Validation(Required=false)]
                public int? ActiveAging { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("FlowLogId")]
                [Validation(Required=false)]
                public string FlowLogId { get; set; }

                [NameInMap("InactiveAging")]
                [Validation(Required=false)]
                public int? InactiveAging { get; set; }

                [NameInMap("LogstoreName")]
                [Validation(Required=false)]
                public string LogstoreName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NetflowServerIp")]
                [Validation(Required=false)]
                public string NetflowServerIp { get; set; }

                [NameInMap("NetflowServerPort")]
                [Validation(Required=false)]
                public string NetflowServerPort { get; set; }

                [NameInMap("NetflowVersion")]
                [Validation(Required=false)]
                public string NetflowVersion { get; set; }

                [NameInMap("OutputType")]
                [Validation(Required=false)]
                public string OutputType { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SlsRegionId")]
                [Validation(Required=false)]
                public string SlsRegionId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TotalSagNum")]
                [Validation(Required=false)]
                public int? TotalSagNum { get; set; }

            }

        }

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
