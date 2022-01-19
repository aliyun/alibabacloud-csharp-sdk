// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListAlarmHistoriesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAlarmHistoriesResponseBodyData> Data { get; set; }
        public class ListAlarmHistoriesResponseBodyData : TeaModel {
            [NameInMap("AlarmContent")]
            [Validation(Required=false)]
            public string AlarmContent { get; set; }

            [NameInMap("AlarmDingDing")]
            [Validation(Required=false)]
            public string AlarmDingDing { get; set; }

            [NameInMap("AlarmEmail")]
            [Validation(Required=false)]
            public string AlarmEmail { get; set; }

            [NameInMap("AlarmName")]
            [Validation(Required=false)]
            public string AlarmName { get; set; }

            [NameInMap("AlarmPhone")]
            [Validation(Required=false)]
            public string AlarmPhone { get; set; }

            [NameInMap("AlarmTime")]
            [Validation(Required=false)]
            public string AlarmTime { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
