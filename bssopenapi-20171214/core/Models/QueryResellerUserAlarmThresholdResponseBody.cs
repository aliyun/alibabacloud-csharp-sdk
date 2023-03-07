// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryResellerUserAlarmThresholdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryResellerUserAlarmThresholdResponseBodyData> Data { get; set; }
        public class QueryResellerUserAlarmThresholdResponseBodyData : TeaModel {
            [NameInMap("Denominator")]
            [Validation(Required=false)]
            public int? Denominator { get; set; }

            [NameInMap("Numerator")]
            [Validation(Required=false)]
            public int? Numerator { get; set; }

            [NameInMap("ThresholdAmount")]
            [Validation(Required=false)]
            public string ThresholdAmount { get; set; }

            [NameInMap("ThresholdType")]
            [Validation(Required=false)]
            public int? ThresholdType { get; set; }

        }

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
