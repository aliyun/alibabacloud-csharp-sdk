// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsTraceGetResultResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceData")]
        [Validation(Required=false)]
        public OnsTraceGetResultResponseBodyTraceData TraceData { get; set; }
        public class OnsTraceGetResultResponseBodyTraceData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("MsgKey")]
            [Validation(Required=false)]
            public string MsgKey { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }
            [NameInMap("TraceList")]
            [Validation(Required=false)]
            public List<OnsTraceGetResultResponseBodyTraceDataTraceList> TraceList { get; set; }
            public class OnsTraceGetResultResponseBodyTraceDataTraceList : TeaModel {
                public string Status { get; set; }
                public string MsgKey { get; set; }
                public long? PubTime { get; set; }
                public List<OnsTraceGetResultResponseBodyTraceDataTraceListSubList> SubList { get; set; }
                public class OnsTraceGetResultResponseBodyTraceDataTraceListSubList : TeaModel {
                    public List<OnsTraceGetResultResponseBodyTraceDataTraceListSubListClientList> ClientList { get; set; }
                    public class OnsTraceGetResultResponseBodyTraceDataTraceListSubListClientList : TeaModel {
                        public string Status { get; set; }
                        public long? SubTime { get; set; }
                        public int? ReconsumeTimes { get; set; }
                        public string SubGroupName { get; set; }
                        public string ClientHost { get; set; }
                        public int? CostTime { get; set; }
                    }
                    public int? FailCount { get; set; }
                    public string SubGroupName { get; set; }
                    public int? SuccessCount { get; set; }
                }
                public string Topic { get; set; }
                public int? CostTime { get; set; }
                public string Tag { get; set; }
                public string MsgId { get; set; }
                public string PubGroupName { get; set; }
                public string BornHost { get; set; }
            }
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }
        };

    }

}
