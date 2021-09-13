// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListIvrTrackingDetailsResponseBody : TeaModel {
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

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIvrTrackingDetailsResponseBodyData Data { get; set; }
        public class ListIvrTrackingDetailsResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListIvrTrackingDetailsResponseBodyDataList> List { get; set; }
            public class ListIvrTrackingDetailsResponseBodyDataList : TeaModel {
                public string Instance { get; set; }
                public string Callee { get; set; }
                public long? EnterTime { get; set; }
                public Dictionary<string, string> NodeVariables { get; set; }
                public string NodeExitCode { get; set; }
                public string FlowName { get; set; }
                public string FlowId { get; set; }
                public Dictionary<string, string> NodeProperties { get; set; }
                public string NodeType { get; set; }
                public string Caller { get; set; }
                public string NodeName { get; set; }
                public string ContactId { get; set; }
                public long? LeaveTime { get; set; }
                public string ChannelVariables { get; set; }
                public string ChannelId { get; set; }
                public string NodeId { get; set; }
            }
        };

    }

}
