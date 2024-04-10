// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetTodayStatTrendResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetTodayStatTrendResponseBodyData> Data { get; set; }
        public class GetTodayStatTrendResponseBodyData : TeaModel {
            [NameInMap("affectedUserCount")]
            [Validation(Required=false)]
            public long? AffectedUserCount { get; set; }

            [NameInMap("affectedUserRate")]
            [Validation(Required=false)]
            public double? AffectedUserRate { get; set; }

            [NameInMap("errorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            [NameInMap("errorRate")]
            [Validation(Required=false)]
            public double? ErrorRate { get; set; }

            [NameInMap("timePoint")]
            [Validation(Required=false)]
            public string TimePoint { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
