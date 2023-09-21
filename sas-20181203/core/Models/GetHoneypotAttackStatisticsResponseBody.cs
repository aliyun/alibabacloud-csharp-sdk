// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetHoneypotAttackStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHoneypotAttackStatisticsResponseBodyData Data { get; set; }
        public class GetHoneypotAttackStatisticsResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("HoneypotAttackStatistics")]
            [Validation(Required=false)]
            public List<GetHoneypotAttackStatisticsResponseBodyDataHoneypotAttackStatistics> HoneypotAttackStatistics { get; set; }
            public class GetHoneypotAttackStatisticsResponseBodyDataHoneypotAttackStatistics : TeaModel {
                [NameInMap("StatisticsCount")]
                [Validation(Required=false)]
                public int? StatisticsCount { get; set; }

                [NameInMap("StatisticsValue")]
                [Validation(Required=false)]
                public string StatisticsValue { get; set; }

            }

            [NameInMap("StatisticsType")]
            [Validation(Required=false)]
            public string StatisticsType { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

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
