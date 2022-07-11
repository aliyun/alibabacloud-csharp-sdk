// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListLegacyAgentStatusLogsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLegacyAgentStatusLogsResponseBodyData Data { get; set; }
        public class ListLegacyAgentStatusLogsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListLegacyAgentStatusLogsResponseBodyDataList> List { get; set; }
            public class ListLegacyAgentStatusLogsResponseBodyDataList : TeaModel {
                public string AgentDropCall { get; set; }
                public string AgentNo { get; set; }
                public string AliHangupCause { get; set; }
                public string CallDir { get; set; }
                public string CallId { get; set; }
                public string CallType { get; set; }
                public string CalleeId { get; set; }
                public string CallerId { get; set; }
                public string ConnId { get; set; }
                public string Extend1 { get; set; }
                public string Extend2 { get; set; }
                public string Extend3 { get; set; }
                public string Extend4 { get; set; }
                public string GroupNo { get; set; }
                public string MonitedAgentNo { get; set; }
                public string MonitedAgentPhoneNo { get; set; }
                public bool? OutboundScenario { get; set; }
                public string PhoneNo { get; set; }
                public string StatisticDate { get; set; }
                public int? StatisticTime { get; set; }
                public string Status { get; set; }
                public string TargetRequest { get; set; }
                public string TargetSelect { get; set; }
                public string TenantId { get; set; }
                public string TransferNo { get; set; }
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
