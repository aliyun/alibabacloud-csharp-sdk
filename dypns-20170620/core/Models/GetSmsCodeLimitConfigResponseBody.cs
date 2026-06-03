// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class GetSmsCodeLimitConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSmsCodeLimitConfigResponseBodyData Data { get; set; }
        public class GetSmsCodeLimitConfigResponseBodyData : TeaModel {
            [NameInMap("LimitDay")]
            [Validation(Required=false)]
            public int? LimitDay { get; set; }

            [NameInMap("LimitHour")]
            [Validation(Required=false)]
            public int? LimitHour { get; set; }

            [NameInMap("LimitId")]
            [Validation(Required=false)]
            public long? LimitId { get; set; }

            [NameInMap("LimitMinute")]
            [Validation(Required=false)]
            public int? LimitMinute { get; set; }

            [NameInMap("LimitOther")]
            [Validation(Required=false)]
            public string LimitOther { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
