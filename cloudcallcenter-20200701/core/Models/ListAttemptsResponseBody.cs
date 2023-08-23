// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
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
                [NameInMap("AgentEstablishedTime")]
                [Validation(Required=false)]
                public long? AgentEstablishedTime { get; set; }

                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                [NameInMap("AgentRingDuration")]
                [Validation(Required=false)]
                public long? AgentRingDuration { get; set; }

                [NameInMap("AssignAgentTime")]
                [Validation(Required=false)]
                public long? AssignAgentTime { get; set; }

                [NameInMap("AttemptId")]
                [Validation(Required=false)]
                public string AttemptId { get; set; }

                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                [NameInMap("CampaignId")]
                [Validation(Required=false)]
                public string CampaignId { get; set; }

                [NameInMap("CaseId")]
                [Validation(Required=false)]
                public string CaseId { get; set; }

                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                [NameInMap("CustomerEstablishedTime")]
                [Validation(Required=false)]
                public long? CustomerEstablishedTime { get; set; }

                [NameInMap("CustomerReleasedTime")]
                [Validation(Required=false)]
                public long? CustomerReleasedTime { get; set; }

                [NameInMap("DialDuration")]
                [Validation(Required=false)]
                public long? DialDuration { get; set; }

                [NameInMap("DialTime")]
                [Validation(Required=false)]
                public long? DialTime { get; set; }

                [NameInMap("EnqueueTime")]
                [Validation(Required=false)]
                public long? EnqueueTime { get; set; }

                [NameInMap("EnterIvrTime")]
                [Validation(Required=false)]
                public long? EnterIvrTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("IvrDuration")]
                [Validation(Required=false)]
                public long? IvrDuration { get; set; }

                [NameInMap("QueueDuration")]
                [Validation(Required=false)]
                public long? QueueDuration { get; set; }

                [NameInMap("QueueId")]
                [Validation(Required=false)]
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

    }

}
