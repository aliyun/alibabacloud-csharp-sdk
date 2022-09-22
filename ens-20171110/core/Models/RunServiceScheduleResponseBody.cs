// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunServiceScheduleResponseBody : TeaModel {
        [NameInMap("CommandResults")]
        [Validation(Required=false)]
        public RunServiceScheduleResponseBodyCommandResults CommandResults { get; set; }
        public class RunServiceScheduleResponseBodyCommandResults : TeaModel {
            [NameInMap("CommandResult")]
            [Validation(Required=false)]
            public List<RunServiceScheduleResponseBodyCommandResultsCommandResult> CommandResult { get; set; }
            public class RunServiceScheduleResponseBodyCommandResultsCommandResult : TeaModel {
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("ContainerName")]
                [Validation(Required=false)]
                public string ContainerName { get; set; }

                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

            }

        }

        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceIp")]
        [Validation(Required=false)]
        public string InstanceIp { get; set; }

        [NameInMap("InstancePort")]
        [Validation(Required=false)]
        public int? InstancePort { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestRepeated")]
        [Validation(Required=false)]
        public string RequestRepeated { get; set; }

        [NameInMap("TcpPorts")]
        [Validation(Required=false)]
        public bool? TcpPorts { get; set; }

    }

}
