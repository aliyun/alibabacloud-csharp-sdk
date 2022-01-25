// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetJobInstanceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetJobInstanceListResponseBodyData Data { get; set; }
        public class GetJobInstanceListResponseBodyData : TeaModel {
            [NameInMap("JobInstanceDetails")]
            [Validation(Required=false)]
            public List<GetJobInstanceListResponseBodyDataJobInstanceDetails> JobInstanceDetails { get; set; }
            public class GetJobInstanceListResponseBodyDataJobInstanceDetails : TeaModel {
                public string DataTime { get; set; }
                public string EndTime { get; set; }
                public string Executor { get; set; }
                public long? InstanceId { get; set; }
                public long? JobId { get; set; }
                public string Progress { get; set; }
                public string Result { get; set; }
                public string ScheduleTime { get; set; }
                public string StartTime { get; set; }
                public int? Status { get; set; }
                public int? TimeType { get; set; }
                public int? TriggerType { get; set; }
                public string WorkAddr { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
