// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetMqSofamqTraceResultResponseBody : TeaModel {
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
        public GetMqSofamqTraceResultResponseBodyData Data { get; set; }
        public class GetMqSofamqTraceResultResponseBodyData : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("MsgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }
            [NameInMap("MsgKey")]
            [Validation(Required=false)]
            public string MsgKey { get; set; }
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("TraceList")]
            [Validation(Required=false)]
            public List<GetMqSofamqTraceResultResponseBodyDataTraceList> TraceList { get; set; }
            public class GetMqSofamqTraceResultResponseBodyDataTraceList : TeaModel {
                public string BornHost { get; set; }
                public string Cell { get; set; }
                public long? CostTime { get; set; }
                public string MsgId { get; set; }
                public string MsgKey { get; set; }
                public string PubGroupName { get; set; }
                public long? PubTime { get; set; }
                public string Status { get; set; }
                public string Tag { get; set; }
                public string Topic { get; set; }
                public List<GetMqSofamqTraceResultResponseBodyDataTraceListSubList> SubList { get; set; }
                public class GetMqSofamqTraceResultResponseBodyDataTraceListSubList : TeaModel {
                    public string Cell { get; set; }
                    public long? FailCount { get; set; }
                    public string SubGroupName { get; set; }
                    public long? SuccessCount { get; set; }
                    public List<GetMqSofamqTraceResultResponseBodyDataTraceListSubListClientList> ClientList { get; set; }
                    public class GetMqSofamqTraceResultResponseBodyDataTraceListSubListClientList : TeaModel {
                        public string ClientHost { get; set; }
                        public long? CostTime { get; set; }
                        public long? ReconsumeTimes { get; set; }
                        public string Status { get; set; }
                        public string SubGroupName { get; set; }
                        public long? SubTime { get; set; }
                    }
                }
            }
        };

    }

}
