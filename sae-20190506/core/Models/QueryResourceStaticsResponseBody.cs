// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class QueryResourceStaticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryResourceStaticsResponseBodyData Data { get; set; }
        public class QueryResourceStaticsResponseBodyData : TeaModel {
            [NameInMap("RealTimeRes")]
            [Validation(Required=false)]
            public QueryResourceStaticsResponseBodyDataRealTimeRes RealTimeRes { get; set; }
            public class QueryResourceStaticsResponseBodyDataRealTimeRes : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

            }
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public QueryResourceStaticsResponseBodyDataSummary Summary { get; set; }
            public class QueryResourceStaticsResponseBodyDataSummary : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public float? Cpu { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public float? Memory { get; set; }

            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
