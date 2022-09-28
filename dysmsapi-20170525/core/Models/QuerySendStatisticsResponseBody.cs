// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendStatisticsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySendStatisticsResponseBodyData Data { get; set; }
        public class QuerySendStatisticsResponseBodyData : TeaModel {
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<QuerySendStatisticsResponseBodyDataTargetList> TargetList { get; set; }
            public class QuerySendStatisticsResponseBodyDataTargetList : TeaModel {
                [NameInMap("NoRespondedCount")]
                [Validation(Required=false)]
                public long? NoRespondedCount { get; set; }

                [NameInMap("RespondedFailCount")]
                [Validation(Required=false)]
                public long? RespondedFailCount { get; set; }

                [NameInMap("RespondedSuccessCount")]
                [Validation(Required=false)]
                public long? RespondedSuccessCount { get; set; }

                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
