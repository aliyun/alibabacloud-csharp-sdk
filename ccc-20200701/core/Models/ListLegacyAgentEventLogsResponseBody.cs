// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListLegacyAgentEventLogsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLegacyAgentEventLogsResponseBodyData Data { get; set; }
        public class ListLegacyAgentEventLogsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListLegacyAgentEventLogsResponseBodyDataList> List { get; set; }
            public class ListLegacyAgentEventLogsResponseBodyDataList : TeaModel {
                [NameInMap("AgentDropCall")]
                [Validation(Required=false)]
                public string AgentDropCall { get; set; }

                [NameInMap("AgentNo")]
                [Validation(Required=false)]
                public string AgentNo { get; set; }

                [NameInMap("CallDir")]
                [Validation(Required=false)]
                public string CallDir { get; set; }

                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                [NameInMap("CallMode")]
                [Validation(Required=false)]
                public string CallMode { get; set; }

                [NameInMap("CallType")]
                [Validation(Required=false)]
                public string CallType { get; set; }

                [NameInMap("CalleeId")]
                [Validation(Required=false)]
                public string CalleeId { get; set; }

                [NameInMap("CallerId")]
                [Validation(Required=false)]
                public string CallerId { get; set; }

                [NameInMap("ConnId")]
                [Validation(Required=false)]
                public string ConnId { get; set; }

                [NameInMap("Event")]
                [Validation(Required=false)]
                public string Event { get; set; }

                [NameInMap("GroupNo")]
                [Validation(Required=false)]
                public string GroupNo { get; set; }

                [NameInMap("OutboundScenario")]
                [Validation(Required=false)]
                public bool? OutboundScenario { get; set; }

                [NameInMap("PhoneNo")]
                [Validation(Required=false)]
                public string PhoneNo { get; set; }

                [NameInMap("StatisticDate")]
                [Validation(Required=false)]
                public string StatisticDate { get; set; }

                [NameInMap("TargetRequest")]
                [Validation(Required=false)]
                public string TargetRequest { get; set; }

                [NameInMap("TargetSelect")]
                [Validation(Required=false)]
                public string TargetSelect { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("TransferNumber")]
                [Validation(Required=false)]
                public string TransferNumber { get; set; }

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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
