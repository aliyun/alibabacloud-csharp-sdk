// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupConfigSynFlowsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Flows")]
        [Validation(Required=false)]
        public DescribeGroupConfigSynFlowsResponseBodyFlows Flows { get; set; }
        public class DescribeGroupConfigSynFlowsResponseBodyFlows : TeaModel {
            [NameInMap("Flow")]
            [Validation(Required=false)]
            public List<DescribeGroupConfigSynFlowsResponseBodyFlowsFlow> Flow { get; set; }
            public class DescribeGroupConfigSynFlowsResponseBodyFlowsFlow : TeaModel {
                public string ApiCopyVersion { get; set; }
                public string SourceGroupId { get; set; }
                public string ModifiedTime { get; set; }
                public string FlowStatus { get; set; }
                public string Region { get; set; }
                public string ExecutionTime { get; set; }
                public string TargetGroupName { get; set; }
                public string TargetGroupId { get; set; }
                public string CreatedTime { get; set; }
                public string FlowId { get; set; }
                public string SourceGroupName { get; set; }
            }
        };

    }

}
