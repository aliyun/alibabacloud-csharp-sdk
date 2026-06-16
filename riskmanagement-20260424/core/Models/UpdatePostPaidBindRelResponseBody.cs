// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class UpdatePostPaidBindRelResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdatePostPaidBindRelResponseBodyData Data { get; set; }
        public class UpdatePostPaidBindRelResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public UpdatePostPaidBindRelResponseBodyDataBody Body { get; set; }
            public class UpdatePostPaidBindRelResponseBodyDataBody : TeaModel {
                [NameInMap("BindCount")]
                [Validation(Required=false)]
                public long? BindCount { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public int? ResultCode { get; set; }

            }

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
