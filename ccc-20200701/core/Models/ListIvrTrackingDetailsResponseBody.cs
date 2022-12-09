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

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIvrTrackingDetailsResponseBodyData Data { get; set; }
        public class ListIvrTrackingDetailsResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListIvrTrackingDetailsResponseBodyDataList> List { get; set; }
            public class ListIvrTrackingDetailsResponseBodyDataList : TeaModel {
                [NameInMap("Callee")]
                [Validation(Required=false)]
                public string Callee { get; set; }

                [NameInMap("Caller")]
                [Validation(Required=false)]
                public string Caller { get; set; }

                [NameInMap("ChannelId")]
                [Validation(Required=false)]
                public string ChannelId { get; set; }

                [NameInMap("ChannelVariables")]
                [Validation(Required=false)]
                public string ChannelVariables { get; set; }

                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public string ContactId { get; set; }

                [NameInMap("EnterTime")]
                [Validation(Required=false)]
                public long? EnterTime { get; set; }

                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public string FlowId { get; set; }

                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public string FlowName { get; set; }

                [NameInMap("Instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                [NameInMap("LeaveTime")]
                [Validation(Required=false)]
                public long? LeaveTime { get; set; }

                [NameInMap("NodeExitCode")]
                [Validation(Required=false)]
                public string NodeExitCode { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("NodeProperties")]
                [Validation(Required=false)]
                public Dictionary<string, object> NodeProperties { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("NodeVariables")]
                [Validation(Required=false)]
                public Dictionary<string, object> NodeVariables { get; set; }

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
