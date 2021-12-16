// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListAttemptsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAttemptsResponseBodyData Data { get; set; }
        public class ListAttemptsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListAttemptsResponseBodyDataList> List { get; set; }
            public class ListAttemptsResponseBodyDataList : TeaModel {
                public long? AgentEstablishedTime { get; set; }
                public string AgentId { get; set; }
                public long? AgentRingDuration { get; set; }
                public long? AssignAgentTime { get; set; }
                public string AttemptId { get; set; }
                public string Callee { get; set; }
                public string Caller { get; set; }
                public string CampaignId { get; set; }
                public string CaseId { get; set; }
                public string ContactId { get; set; }
                public long? CustomerEstablishedTime { get; set; }
                public long? CustomerReleasedTime { get; set; }
                public long? DialDuration { get; set; }
                public long? DialTime { get; set; }
                public long? EnqueueTime { get; set; }
                public long? EnterIvrTime { get; set; }
                public string InstanceId { get; set; }
                public long? IvrDuration { get; set; }
                public long? QueueDuration { get; set; }
                public string QueueId { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
