// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetDailyReportPidParamResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("DayPidParamRsp")]
        [Validation(Required=true)]
        public GetDailyReportPidParamResponseDayPidParamRsp DayPidParamRsp { get; set; }
        public class GetDailyReportPidParamResponseDayPidParamRsp : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("DayPidParam")]
            [Validation(Required=true)]
            public GetDailyReportPidParamResponseDayPidParamRspDayPidParam DayPidParam { get; set; }
            public class GetDailyReportPidParamResponseDayPidParamRspDayPidParam : TeaModel {
                [NameInMap("Kp")]
                [Validation(Required=true)]
                public float? Kp { get; set; }

                [NameInMap("Ti")]
                [Validation(Required=true)]
                public float? Ti { get; set; }

                [NameInMap("Td")]
                [Validation(Required=true)]
                public float? Td { get; set; }

                [NameInMap("RecommendIndex")]
                [Validation(Required=true)]
                public float? RecommendIndex { get; set; }

            }
        };

    }

}
