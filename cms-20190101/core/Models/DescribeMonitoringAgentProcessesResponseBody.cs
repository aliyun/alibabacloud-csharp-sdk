// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentProcessesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The value 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The information about the processes.
        /// </summary>
        [NameInMap("NodeProcesses")]
        [Validation(Required=false)]
        public DescribeMonitoringAgentProcessesResponseBodyNodeProcesses NodeProcesses { get; set; }
        public class DescribeMonitoringAgentProcessesResponseBodyNodeProcesses : TeaModel {
            [NameInMap("NodeProcess")]
            [Validation(Required=false)]
            public List<DescribeMonitoringAgentProcessesResponseBodyNodeProcessesNodeProcess> NodeProcess { get; set; }
            public class DescribeMonitoringAgentProcessesResponseBodyNodeProcessesNodeProcess : TeaModel {
                /// <summary>
                /// The command used to obtain the number of processes. Valid value: `number`.
                /// 
                /// >  The `number` command obtains the number of processes that match the condition.
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the process.
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public long? ProcessId { get; set; }

                /// <summary>
                /// The name of the process.
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

                /// <summary>
                /// The user who launched the process.
                /// </summary>
                [NameInMap("ProcessUser")]
                [Validation(Required=false)]
                public string ProcessUser { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
