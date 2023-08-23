// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetScheduleTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetScheduleTaskResponseBodyResult Result { get; set; }
        public class GetScheduleTaskResponseBodyResult : TeaModel {
            [NameInMap("ActionTopicList")]
            [Validation(Required=false)]
            public List<GetScheduleTaskResponseBodyResultActionTopicList> ActionTopicList { get; set; }
            public class GetScheduleTaskResponseBodyResultActionTopicList : TeaModel {
                [NameInMap("CustomAction")]
                [Validation(Required=false)]
                public Dictionary<string, object> CustomAction { get; set; }

            }

            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            [NameInMap("ScheduleEndTime")]
            [Validation(Required=false)]
            public string ScheduleEndTime { get; set; }

            [NameInMap("ScheduleId")]
            [Validation(Required=false)]
            public long? ScheduleId { get; set; }

            [NameInMap("ScheduleStartTime")]
            [Validation(Required=false)]
            public string ScheduleStartTime { get; set; }

            [NameInMap("ScheduleType")]
            [Validation(Required=false)]
            public string ScheduleType { get; set; }

        }

    }

}
