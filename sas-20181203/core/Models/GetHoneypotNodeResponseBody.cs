// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotNodeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HoneypotNode")]
        [Validation(Required=false)]
        public GetHoneypotNodeResponseBodyHoneypotNode HoneypotNode { get; set; }
        public class GetHoneypotNodeResponseBodyHoneypotNode : TeaModel {
            [NameInMap("AllowHoneypotAccessInternet")]
            [Validation(Required=false)]
            public bool? AllowHoneypotAccessInternet { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            [NameInMap("HoneypotTotalCount")]
            [Validation(Required=false)]
            public int? HoneypotTotalCount { get; set; }

            [NameInMap("HoneypotUsedCount")]
            [Validation(Required=false)]
            public int? HoneypotUsedCount { get; set; }

            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("NodeIp")]
            [Validation(Required=false)]
            public string NodeIp { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            [NameInMap("ProbeTotalCount")]
            [Validation(Required=false)]
            public int? ProbeTotalCount { get; set; }

            [NameInMap("ProbeUsedCount")]
            [Validation(Required=false)]
            public int? ProbeUsedCount { get; set; }

            [NameInMap("SecurityGroupProbeIpList")]
            [Validation(Required=false)]
            public List<string> SecurityGroupProbeIpList { get; set; }

            [NameInMap("TotalStatus")]
            [Validation(Required=false)]
            public int? TotalStatus { get; set; }

            [NameInMap("UpgradeAvailable")]
            [Validation(Required=false)]
            public bool? UpgradeAvailable { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
