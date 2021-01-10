// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlarmHistoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public List<QueryRmsAlarmHistoryResponseBodyResponse> Response { get; set; }
        public class QueryRmsAlarmHistoryResponseBodyResponse : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("MetricGroupId")]
            [Validation(Required=false)]
            public string MetricGroupId { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public long? Period { get; set; }

        }

    }

}
