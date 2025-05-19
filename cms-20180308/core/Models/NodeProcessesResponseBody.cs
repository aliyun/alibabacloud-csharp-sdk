// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class NodeProcessesResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("NodeProcesses")]
        [Validation(Required=false)]
        public NodeProcessesResponseBodyNodeProcesses NodeProcesses { get; set; }
        public class NodeProcessesResponseBodyNodeProcesses : TeaModel {
            [NameInMap("NodeProcess")]
            [Validation(Required=false)]
            public List<NodeProcessesResponseBodyNodeProcessesNodeProcess> NodeProcess { get; set; }
            public class NodeProcessesResponseBodyNodeProcessesNodeProcess : TeaModel {
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

                [NameInMap("ProcessUser")]
                [Validation(Required=false)]
                public string ProcessUser { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
