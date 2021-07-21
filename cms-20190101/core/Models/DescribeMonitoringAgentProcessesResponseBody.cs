// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentProcessesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("NodeProcesses")]
        [Validation(Required=false)]
        public DescribeMonitoringAgentProcessesResponseBodyNodeProcesses NodeProcesses { get; set; }
        public class DescribeMonitoringAgentProcessesResponseBodyNodeProcesses : TeaModel {
            [NameInMap("NodeProcess")]
            [Validation(Required=false)]
            public List<DescribeMonitoringAgentProcessesResponseBodyNodeProcessesNodeProcess> NodeProcess { get; set; }
            public class DescribeMonitoringAgentProcessesResponseBodyNodeProcessesNodeProcess : TeaModel {
                public string ProcessName { get; set; }
                public long? ProcessId { get; set; }
                public string GroupId { get; set; }
                public string Command { get; set; }
                public string ProcessUser { get; set; }
                public string InstanceId { get; set; }
            }
        };

    }

}
