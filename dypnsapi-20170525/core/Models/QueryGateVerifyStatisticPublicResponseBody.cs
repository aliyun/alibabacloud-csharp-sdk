// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class QueryGateVerifyStatisticPublicResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryGateVerifyStatisticPublicResponseBodyData Data { get; set; }
        public class QueryGateVerifyStatisticPublicResponseBodyData : TeaModel {
            [NameInMap("DayStatistic")]
            [Validation(Required=false)]
            public List<QueryGateVerifyStatisticPublicResponseBodyDataDayStatistic> DayStatistic { get; set; }
            public class QueryGateVerifyStatisticPublicResponseBodyDataDayStatistic : TeaModel {
                [NameInMap("StatisticDateStr")]
                [Validation(Required=false)]
                public string StatisticDateStr { get; set; }

                [NameInMap("TotalFail")]
                [Validation(Required=false)]
                public long? TotalFail { get; set; }

                [NameInMap("TotalSuccess")]
                [Validation(Required=false)]
                public long? TotalSuccess { get; set; }

                [NameInMap("TotalUnknown")]
                [Validation(Required=false)]
                public long? TotalUnknown { get; set; }

            }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

            [NameInMap("TotalFail")]
            [Validation(Required=false)]
            public long? TotalFail { get; set; }

            [NameInMap("TotalSuccess")]
            [Validation(Required=false)]
            public long? TotalSuccess { get; set; }

            [NameInMap("TotalUnknown")]
            [Validation(Required=false)]
            public long? TotalUnknown { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
