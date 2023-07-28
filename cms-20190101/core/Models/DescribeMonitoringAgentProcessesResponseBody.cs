// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentProcessesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the processes.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the process.
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
                /// The ID of the instance.
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// The user who launched the process.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The command used to obtain the number of processes. Valid value: `number`.
                /// 
                /// >  The `number` command obtains the number of processes that match the condition.
                /// </summary>
                [NameInMap("ProcessId")]
                [Validation(Required=false)]
                public long? ProcessId { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

                /// <summary>
                /// >  Before you call this operation, call the CreateMonitoringAgentProcess operation to create processes. For more information, see [CreateMonitoringAgentProcess](~~114951~~~).
                /// 
                /// This topic provides an example of how to query the processes of the `i-hp3hl3cx1pbahzy8****` instance. The response indicates the details of the `NGINX` and `HTTP` processes.
                /// </summary>
                [NameInMap("ProcessUser")]
                [Validation(Required=false)]
                public string ProcessUser { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the process.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
