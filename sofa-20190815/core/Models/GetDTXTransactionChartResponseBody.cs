// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDTXTransactionChartResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDTXTransactionChartResponseBodyData Data { get; set; }
        public class GetDTXTransactionChartResponseBodyData : TeaModel {
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }
            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public long? Cost { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("LastHandleTime")]
            [Validation(Required=false)]
            public string LastHandleTime { get; set; }
            [NameInMap("LowerLineCount")]
            [Validation(Required=false)]
            public long? LowerLineCount { get; set; }
            [NameInMap("ParticipatorNum")]
            [Validation(Required=false)]
            public long? ParticipatorNum { get; set; }
            [NameInMap("StarterIp")]
            [Validation(Required=false)]
            public string StarterIp { get; set; }
            [NameInMap("StarterName")]
            [Validation(Required=false)]
            public string StarterName { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("TxId")]
            [Validation(Required=false)]
            public string TxId { get; set; }
            [NameInMap("UpperLineCount")]
            [Validation(Required=false)]
            public long? UpperLineCount { get; set; }
            [NameInMap("Edges")]
            [Validation(Required=false)]
            public List<GetDTXTransactionChartResponseBodyDataEdges> Edges { get; set; }
            public class GetDTXTransactionChartResponseBodyDataEdges : TeaModel {
                public string Content { get; set; }
                public string ErrorMessage { get; set; }
                public long? Id { get; set; }
                public bool? IsError { get; set; }
                public long? Source { get; set; }
                public long? Target { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<GetDTXTransactionChartResponseBodyDataNodes> Nodes { get; set; }
            public class GetDTXTransactionChartResponseBodyDataNodes : TeaModel {
                public string EndTime { get; set; }
                public long? Id { get; set; }
                public bool? IsEnd { get; set; }
                public string Label { get; set; }
                public string Name { get; set; }
                public string Role { get; set; }
                public string StartTime { get; set; }
            }
        };

    }

}
