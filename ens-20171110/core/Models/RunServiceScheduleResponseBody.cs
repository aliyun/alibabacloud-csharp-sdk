// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunServiceScheduleResponseBody : TeaModel {
        /// <summary>
        /// The execution results of the commands.
        /// </summary>
        [NameInMap("CommandResults")]
        [Validation(Required=false)]
        public RunServiceScheduleResponseBodyCommandResults CommandResults { get; set; }
        public class RunServiceScheduleResponseBodyCommandResults : TeaModel {
            [NameInMap("CommandResult")]
            [Validation(Required=false)]
            public List<RunServiceScheduleResponseBodyCommandResultsCommandResult> CommandResult { get; set; }
            public class RunServiceScheduleResponseBodyCommandResultsCommandResult : TeaModel {
                /// <summary>
                /// The command.
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// The name of the container.
                /// </summary>
                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

                /// <summary>
                /// The execution result of the command.
                /// </summary>
                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

            }

        }

        /// <summary>
        /// The index number of the scheduled virtual device (pod).
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        /// <summary>
        /// The ID of the scheduled instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The IP address of the scheduled instance.
        /// </summary>
        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        /// <summary>
        /// The start port of the scheduled instance.
        /// </summary>
        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is repeated. This parameter is not returned if ServcieAction is set to Console.
        /// </summary>
        [NameInMap("RequestRepeated")]
        [Validation(Required=false)]
        public string RequestRepeated { get; set; }

        /// <summary>
        /// The TCP port range of the scheduled instance or container. The value is in the ${from}-$-{to} format. Example: 80-88.
        /// </summary>
        [NameInMap("TcpPorts")]
        [Validation(Required=false)]
        public bool? TcpPorts { get; set; }

    }

}
