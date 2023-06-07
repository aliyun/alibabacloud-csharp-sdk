// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetLaunchTrendResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetLaunchTrendResponseBodyData> Data { get; set; }
        public class GetLaunchTrendResponseBodyData : TeaModel {
            [NameInMap("coldLaunchCount")]
            [Validation(Required=false)]
            public long? ColdLaunchCount { get; set; }

            [NameInMap("coldLaunchDuration")]
            [Validation(Required=false)]
            public double? ColdLaunchDuration { get; set; }

            [NameInMap("firstLaunchCount")]
            [Validation(Required=false)]
            public long? FirstLaunchCount { get; set; }

            [NameInMap("firstLaunchDuration")]
            [Validation(Required=false)]
            public double? FirstLaunchDuration { get; set; }

            [NameInMap("hotLaunchCount")]
            [Validation(Required=false)]
            public long? HotLaunchCount { get; set; }

            [NameInMap("hotLaunchDuration")]
            [Validation(Required=false)]
            public double? HotLaunchDuration { get; set; }

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
