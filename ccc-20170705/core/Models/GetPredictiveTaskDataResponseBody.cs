// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetPredictiveTaskDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPredictiveTaskDataResponseBodyData Data { get; set; }
        public class GetPredictiveTaskDataResponseBodyData : TeaModel {
            [NameInMap("Abandoned")]
            [Validation(Required=false)]
            public bool? Abandoned { get; set; }
            [NameInMap("Answered")]
            [Validation(Required=false)]
            public bool? Answered { get; set; }
            [NameInMap("Connected")]
            [Validation(Required=false)]
            public bool? Connected { get; set; }
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }
            [NameInMap("DialDuration")]
            [Validation(Required=false)]
            public long? DialDuration { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }
            [NameInMap("QueueDuration")]
            [Validation(Required=false)]
            public long? QueueDuration { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }
            [NameInMap("TalkDuration")]
            [Validation(Required=false)]
            public long? TalkDuration { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
