// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetSummaryInfoResponseBody : TeaModel {
        [NameInMap("AgentBotInstanceSummaryList")]
        [Validation(Required=false)]
        public List<GetSummaryInfoResponseBodyAgentBotInstanceSummaryList> AgentBotInstanceSummaryList { get; set; }
        public class GetSummaryInfoResponseBodyAgentBotInstanceSummaryList : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("TotalCallCount")]
            [Validation(Required=false)]
            public long? TotalCallCount { get; set; }

            [NameInMap("TotalCallTime")]
            [Validation(Required=false)]
            public long? TotalCallTime { get; set; }

            [NameInMap("UsedRecordingStorageSpace")]
            [Validation(Required=false)]
            public int? UsedRecordingStorageSpace { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
