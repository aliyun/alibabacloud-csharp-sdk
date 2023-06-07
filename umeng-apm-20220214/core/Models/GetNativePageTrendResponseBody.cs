// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetNativePageTrendResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetNativePageTrendResponseBodyData> Data { get; set; }
        public class GetNativePageTrendResponseBodyData : TeaModel {
            [NameInMap("avgLoadDuration")]
            [Validation(Required=false)]
            public double? AvgLoadDuration { get; set; }

            [NameInMap("crashRate")]
            [Validation(Required=false)]
            public double? CrashRate { get; set; }

            [NameInMap("loadCnt")]
            [Validation(Required=false)]
            public long? LoadCnt { get; set; }

            [NameInMap("slowLoadRate")]
            [Validation(Required=false)]
            public double? SlowLoadRate { get; set; }

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
