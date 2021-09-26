// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class DescribeFlowNodeInstanceLauncherLogResponseBody : TeaModel {
        [NameInMap("LogEnd")]
        [Validation(Required=false)]
        public bool? LogEnd { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LogEntrys")]
        [Validation(Required=false)]
        public DescribeFlowNodeInstanceLauncherLogResponseBodyLogEntrys LogEntrys { get; set; }
        public class DescribeFlowNodeInstanceLauncherLogResponseBodyLogEntrys : TeaModel {
            [NameInMap("LogEntry")]
            [Validation(Required=false)]
            public List<DescribeFlowNodeInstanceLauncherLogResponseBodyLogEntrysLogEntry> LogEntry { get; set; }
            public class DescribeFlowNodeInstanceLauncherLogResponseBodyLogEntrysLogEntry : TeaModel {
                public string Content { get; set; }
            }
        };

    }

}
