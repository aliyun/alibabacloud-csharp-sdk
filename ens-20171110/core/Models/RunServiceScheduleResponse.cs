// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RunServiceScheduleResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RequestRepeated")]
        [Validation(Required=true)]
        public string RequestRepeated { get; set; }

        [NameInMap("TcpPorts")]
        [Validation(Required=true)]
        public bool? TcpPorts { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("InstancePort")]
        [Validation(Required=true)]
        public int? InstancePort { get; set; }

        [NameInMap("InstanceIp")]
        [Validation(Required=true)]
        public string InstanceIp { get; set; }

        [NameInMap("Index")]
        [Validation(Required=true)]
        public int? Index { get; set; }

        [NameInMap("CommandResults")]
        [Validation(Required=true)]
        public RunServiceScheduleResponseCommandResults CommandResults { get; set; }
        public class RunServiceScheduleResponseCommandResults : TeaModel {
            [NameInMap("CommandResult")]
            [Validation(Required=true)]
            public List<RunServiceScheduleResponseCommandResultsCommandResult> CommandResult { get; set; }
            public class RunServiceScheduleResponseCommandResultsCommandResult : TeaModel {
                public string ContainerName { get; set; }
                public string Command { get; set; }
                public string ResultMsg { get; set; }
            }
        };

    }

}
