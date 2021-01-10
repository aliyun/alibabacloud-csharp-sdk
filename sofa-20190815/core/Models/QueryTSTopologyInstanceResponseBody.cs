// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryTSTopologyInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTSTopologyInstanceResponseBodyData Data { get; set; }
        public class QueryTSTopologyInstanceResponseBodyData : TeaModel {
            [NameInMap("BaseVersion")]
            [Validation(Required=false)]
            public long? BaseVersion { get; set; }
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }
            [NameInMap("Edges")]
            [Validation(Required=false)]
            public List<QueryTSTopologyInstanceResponseBodyDataEdges> Edges { get; set; }
            public class QueryTSTopologyInstanceResponseBodyDataEdges : TeaModel {
                public bool? ConditionValue { get; set; }
                public string Source { get; set; }
                public string Status { get; set; }
                public string Target { get; set; }
            }
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<QueryTSTopologyInstanceResponseBodyDataNodes> Nodes { get; set; }
            public class QueryTSTopologyInstanceResponseBodyDataNodes : TeaModel {
                public long? ActivityId { get; set; }
                public long? ActivityInstanceId { get; set; }
                public string App { get; set; }
                public bool? CanSuspend { get; set; }
                public string Comment { get; set; }
                public string Condition { get; set; }
                public long? Consume { get; set; }
                public long? CreateTimestamp { get; set; }
                public long? CurSharding { get; set; }
                public string GmtBegin { get; set; }
                public string GmtEnd { get; set; }
                public long? Id { get; set; }
                public bool? IsInShardingGateway { get; set; }
                public string JobDes { get; set; }
                public long? JobId { get; set; }
                public string JobType { get; set; }
                public bool? Lock { get; set; }
                public string Name { get; set; }
                public bool? NeedConfirm { get; set; }
                public long? ParallelCount { get; set; }
                public long? ParentActivityInstanceId { get; set; }
                public string Status { get; set; }
                public string SubProcessRequestId { get; set; }
                public long? SucceedShardingNum { get; set; }
                public string TopologyStatus { get; set; }
                public long? TotalShardingNum { get; set; }
                public string Type { get; set; }
                public List<QueryTSTopologyInstanceResponseBodyDataNodesActivityEvents> ActivityEvents { get; set; }
                public class QueryTSTopologyInstanceResponseBodyDataNodesActivityEvents : TeaModel {
                    public long? ActivityId { get; set; }
                    public string Extra { get; set; }
                    public long? Id { get; set; }
                    public long? ProcessId { get; set; }
                    public string Type { get; set; }
                }
                public List<QueryTSTopologyInstanceResponseBodyDataNodesEvents> Events { get; set; }
                public class QueryTSTopologyInstanceResponseBodyDataNodesEvents : TeaModel {
                    public long? ActivityId { get; set; }
                    public string Extra { get; set; }
                    public long? Id { get; set; }
                    public long? ProcessId { get; set; }
                    public string Type { get; set; }
                }
            }
        };

    }

}
