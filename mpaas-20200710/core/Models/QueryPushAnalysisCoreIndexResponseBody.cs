// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class QueryPushAnalysisCoreIndexResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryPushAnalysisCoreIndexResponseBodyResultContent ResultContent { get; set; }
        public class QueryPushAnalysisCoreIndexResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryPushAnalysisCoreIndexResponseBodyResultContentData Data { get; set; }
            public class QueryPushAnalysisCoreIndexResponseBodyResultContentData : TeaModel {
                [NameInMap("ArrivalNum")]
                [Validation(Required=false)]
                public float? ArrivalNum { get; set; }

                [NameInMap("ArrivalRate")]
                [Validation(Required=false)]
                public float? ArrivalRate { get; set; }

                [NameInMap("IgnoreNum")]
                [Validation(Required=false)]
                public float? IgnoreNum { get; set; }

                [NameInMap("IgnoreRate")]
                [Validation(Required=false)]
                public float? IgnoreRate { get; set; }

                [NameInMap("OpenNum")]
                [Validation(Required=false)]
                public float? OpenNum { get; set; }

                [NameInMap("OpenRate")]
                [Validation(Required=false)]
                public float? OpenRate { get; set; }

                [NameInMap("PushNum")]
                [Validation(Required=false)]
                public float? PushNum { get; set; }

                [NameInMap("PushTotalNum")]
                [Validation(Required=false)]
                public float? PushTotalNum { get; set; }

            }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
