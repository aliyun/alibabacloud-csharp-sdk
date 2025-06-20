// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class SafeChangeStartResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SafeChangeStartResponseBodyData Data { get; set; }
        public class SafeChangeStartResponseBodyData : TeaModel {
            [NameInMap("ApproveResultUrl")]
            [Validation(Required=false)]
            public string ApproveResultUrl { get; set; }

            [NameInMap("CheckResultUrl")]
            [Validation(Required=false)]
            public string CheckResultUrl { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubSatus")]
            [Validation(Required=false)]
            public string SubSatus { get; set; }

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
