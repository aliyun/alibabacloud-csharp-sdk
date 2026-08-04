// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class BatchQueryModifyLoginEmailTraceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<BatchQueryModifyLoginEmailTraceResponseBodyTraces> Traces { get; set; }
        public class BatchQueryModifyLoginEmailTraceResponseBodyTraces : TeaModel {
            [NameInMap("NewLoginEmail")]
            [Validation(Required=false)]
            public string NewLoginEmail { get; set; }

            [NameInMap("NowLoginEmail")]
            [Validation(Required=false)]
            public string NowLoginEmail { get; set; }

            [NameInMap("OldLoginEmail")]
            [Validation(Required=false)]
            public string OldLoginEmail { get; set; }

            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TraceNo")]
            [Validation(Required=false)]
            public string TraceNo { get; set; }

        }

    }

}
