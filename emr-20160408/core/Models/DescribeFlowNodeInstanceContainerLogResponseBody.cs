// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeFlowNodeInstanceContainerLogResponseBody : TeaModel {
        [NameInMap("LogEnd")]
        [Validation(Required=false)]
        public bool? LogEnd { get; set; }

        [NameInMap("LogEntrys")]
        [Validation(Required=false)]
        public DescribeFlowNodeInstanceContainerLogResponseBodyLogEntrys LogEntrys { get; set; }
        public class DescribeFlowNodeInstanceContainerLogResponseBodyLogEntrys : TeaModel {
            [NameInMap("LogEntry")]
            [Validation(Required=false)]
            public List<DescribeFlowNodeInstanceContainerLogResponseBodyLogEntrysLogEntry> LogEntry { get; set; }
            public class DescribeFlowNodeInstanceContainerLogResponseBodyLogEntrysLogEntry : TeaModel {
                public string Content { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
