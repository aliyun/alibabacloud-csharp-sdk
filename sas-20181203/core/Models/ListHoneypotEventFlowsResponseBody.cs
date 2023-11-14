// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotEventFlowsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HoneypotEventFlows")]
        [Validation(Required=false)]
        public List<ListHoneypotEventFlowsResponseBodyHoneypotEventFlows> HoneypotEventFlows { get; set; }
        public class ListHoneypotEventFlowsResponseBodyHoneypotEventFlows : TeaModel {
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            [NameInMap("DockerId")]
            [Validation(Required=false)]
            public string DockerId { get; set; }

            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            [NameInMap("EventConnection")]
            [Validation(Required=false)]
            public string EventConnection { get; set; }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("Extra1")]
            [Validation(Required=false)]
            public string Extra1 { get; set; }

            [NameInMap("FileOssUrl")]
            [Validation(Required=false)]
            public string FileOssUrl { get; set; }

            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            [NameInMap("HoneypotEventId")]
            [Validation(Required=false)]
            public string HoneypotEventId { get; set; }

            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }

            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }

            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            [NameInMap("SrcIp")]
            [Validation(Required=false)]
            public string SrcIp { get; set; }

            [NameInMap("SrcMac")]
            [Validation(Required=false)]
            public string SrcMac { get; set; }

            [NameInMap("SrcPort")]
            [Validation(Required=false)]
            public int? SrcPort { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TypeId")]
            [Validation(Required=false)]
            public string TypeId { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotEventFlowsResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotEventFlowsResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
