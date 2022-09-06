// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetBaseStrategyPeriodResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("OnlyWeekdays")]
        [Validation(Required=false)]
        public bool? OnlyWeekdays { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("WorkingTime")]
        [Validation(Required=false)]
        public List<GetBaseStrategyPeriodResponseBodyWorkingTime> WorkingTime { get; set; }
        public class GetBaseStrategyPeriodResponseBodyWorkingTime : TeaModel {
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }

            [NameInMap("BeginTimeMillis")]
            [Validation(Required=false)]
            public long? BeginTimeMillis { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EndTimeMillis")]
            [Validation(Required=false)]
            public long? EndTimeMillis { get; set; }

        }

    }

}
