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
            public OnsTraceGetResultResponseBodyTraceDataTraceList TraceList { get; set; }
            public class OnsTraceGetResultResponseBodyTraceDataTraceList : TeaModel {
                [NameInMap("TraceMapDo")]
                [Validation(Required=false)]
                public List<OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDo> TraceMapDo { get; set; }
                public class OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDo : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("MsgKey")]
                    [Validation(Required=false)]
                    public string MsgKey { get; set; }

                    [NameInMap("PubTime")]
                    [Validation(Required=false)]
                    public long? PubTime { get; set; }

                    [NameInMap("SubList")]
                    [Validation(Required=false)]
                    public OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubList SubList { get; set; }
                    public class OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubList : TeaModel {
                        [NameInMap("SubMapDo")]
                        [Validation(Required=false)]
                        public List<OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDo> SubMapDo { get; set; }
                        public class OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDo : TeaModel {
                            [NameInMap("SubClientInfoDo")]
                            [Validation(Required=false)]
                            public List<OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDoSubClientInfoDo> SubClientInfoDo { get; set; }
                            public class OnsTraceGetResultResponseBodyTraceDataTraceListTraceMapDoSubListSubMapDoSubClientInfoDo : TeaModel {
                                [NameInMap("Status")]
                                [Validation(Required=false)]
                                public string Status { get; set; }

                                [NameInMap("SubTime")]
                                [Validation(Required=false)]
                                public long? SubTime { get; set; }

                                [NameInMap("ReconsumeTimes")]
                                [Validation(Required=false)]
                                public int? ReconsumeTimes { get; set; }

                                [NameInMap("SubGroupName")]
                                [Validation(Required=false)]
                                public string SubGroupName { get; set; }

                                [NameInMap("ClientHost")]
                                [Validation(Required=false)]
                                public string ClientHost { get; set; }

                                [NameInMap("CostTime")]
                                [Validation(Required=false)]
                                public int? CostTime { get; set; }

                            }

                        }
                    };

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                    [NameInMap("CostTime")]
                    [Validation(Required=false)]
                    public int? CostTime { get; set; }

                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    [NameInMap("MsgId")]
                    [Validation(Required=false)]
                    public string MsgId { get; set; }

                    [NameInMap("PubGroupName")]
                    [Validation(Required=false)]
                    public string PubGroupName { get; set; }

                    [NameInMap("BornHost")]
                    [Validation(Required=false)]
                    public string BornHost { get; set; }

                }

            }
            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }
        };

    }

}
