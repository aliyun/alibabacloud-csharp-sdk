// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20230630.Models
{
    public class ConsumeFreeStorageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ConsumeFreeStorageResponseBodyData Data { get; set; }
        public class ConsumeFreeStorageResponseBodyData : TeaModel {
            [NameInMap("Consumed")]
            [Validation(Required=false)]
            public int? Consumed { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("EndTimeUTC")]
            [Validation(Required=false)]
            public string EndTimeUTC { get; set; }

            [NameInMap("Expired")]
            [Validation(Required=false)]
            public int? Expired { get; set; }

            [NameInMap("Lifecycle")]
            [Validation(Required=false)]
            public int? Lifecycle { get; set; }

            [NameInMap("Months")]
            [Validation(Required=false)]
            public int? Months { get; set; }

            [NameInMap("RemainQuota")]
            [Validation(Required=false)]
            public int? RemainQuota { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("StartTimeUTC")]
            [Validation(Required=false)]
            public string StartTimeUTC { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
