// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAliYunSafeCenterResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultResponseBodyData Data { get; set; }
        public class GetAliYunSafeCenterResultResponseBodyData : TeaModel {
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public bool? AgentStatus { get; set; }

            [NameInMap("EcsInstanceStatus")]
            [Validation(Required=false)]
            public bool? EcsInstanceStatus { get; set; }

            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<long?> InstanceIds { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("SwasInstanceStatus")]
            [Validation(Required=false)]
            public bool? SwasInstanceStatus { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public bool? TaskStatus { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
