// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListAgentStatesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAgentStatesResponseBodyData Data { get; set; }
        public class ListAgentStatesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListAgentStatesResponseBodyDataList List { get; set; }
            public class ListAgentStatesResponseBodyDataList : TeaModel {
                [NameInMap("RealTimeAgentState")]
                [Validation(Required=false)]
                public List<ListAgentStatesResponseBodyDataListRealTimeAgentState> RealTimeAgentState { get; set; }
                public class ListAgentStatesResponseBodyDataListRealTimeAgentState : TeaModel {
                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("Dn")]
                    [Validation(Required=false)]
                    public string Dn { get; set; }

                    [NameInMap("StateDuration")]
                    [Validation(Required=false)]
                    public string StateDuration { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("AgentId")]
                    [Validation(Required=false)]
                    public string AgentId { get; set; }

                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                }

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

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
