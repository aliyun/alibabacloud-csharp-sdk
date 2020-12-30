// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class QueryCardHistoryFlowInfoResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCardHistoryFlowInfoResponseBodyData> Data { get; set; }
        public class QueryCardHistoryFlowInfoResponseBodyData : TeaModel {
            [NameInMap("DayUsageList")]
            [Validation(Required=false)]
            public List<QueryCardHistoryFlowInfoResponseBodyDataDayUsageList> DayUsageList { get; set; }
            public class QueryCardHistoryFlowInfoResponseBodyDataDayUsageList : TeaModel {
                [NameInMap("Day")]
                [Validation(Required=false)]
                public int? Day { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

            [NameInMap("Month")]
            [Validation(Required=false)]
            public long? Month { get; set; }

            [NameInMap("CurValue")]
            [Validation(Required=false)]
            public long? CurValue { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
