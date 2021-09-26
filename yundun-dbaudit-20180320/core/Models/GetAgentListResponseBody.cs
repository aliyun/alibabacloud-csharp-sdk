// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class GetAgentListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AgentList")]
        [Validation(Required=false)]
        public List<GetAgentListResponseBodyAgentList> AgentList { get; set; }
        public class GetAgentListResponseBodyAgentList : TeaModel {
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("PrivateIp")]
            [Validation(Required=false)]
            public string PrivateIp { get; set; }

            [NameInMap("RmagentMem")]
            [Validation(Required=false)]
            public int? RmagentMem { get; set; }

            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("RmagentCpu")]
            [Validation(Required=false)]
            public int? RmagentCpu { get; set; }

            [NameInMap("FirstLoginTime")]
            [Validation(Required=false)]
            public string FirstLoginTime { get; set; }

            [NameInMap("AgentOs")]
            [Validation(Required=false)]
            public string AgentOs { get; set; }

            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public int? AgentStatus { get; set; }

            [NameInMap("AgentPort")]
            [Validation(Required=false)]
            public string AgentPort { get; set; }

            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            [NameInMap("SendPackets")]
            [Validation(Required=false)]
            public long? SendPackets { get; set; }

            [NameInMap("SendBytes")]
            [Validation(Required=false)]
            public long? SendBytes { get; set; }

            [NameInMap("LastActiveTime")]
            [Validation(Required=false)]
            public string LastActiveTime { get; set; }

            [NameInMap("SendPacketCount")]
            [Validation(Required=false)]
            public long? SendPacketCount { get; set; }

            [NameInMap("EcsId")]
            [Validation(Required=false)]
            public string EcsId { get; set; }

            [NameInMap("PublicIp")]
            [Validation(Required=false)]
            public string PublicIp { get; set; }

            [NameInMap("SendByteCount")]
            [Validation(Required=false)]
            public long? SendByteCount { get; set; }

        }

    }

}
