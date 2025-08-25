// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class QueryPushAnalysisTaskDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public QueryPushAnalysisTaskDetailResponseBodyResultContent ResultContent { get; set; }
        public class QueryPushAnalysisTaskDetailResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public QueryPushAnalysisTaskDetailResponseBodyResultContentData Data { get; set; }
            public class QueryPushAnalysisTaskDetailResponseBodyResultContentData : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("PushArrivalNum")]
                [Validation(Required=false)]
                public float? PushArrivalNum { get; set; }

                [NameInMap("PushNum")]
                [Validation(Required=false)]
                public float? PushNum { get; set; }

                [NameInMap("PushSuccessNum")]
                [Validation(Required=false)]
                public float? PushSuccessNum { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

            }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
