// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ApplyFileUploadLeaseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ApplyFileUploadLeaseResponseBodyData Data { get; set; }
        public class ApplyFileUploadLeaseResponseBodyData : TeaModel {
            [NameInMap("FileUploadLeaseId")]
            [Validation(Required=false)]
            public string FileUploadLeaseId { get; set; }

            [NameInMap("Param")]
            [Validation(Required=false)]
            public ApplyFileUploadLeaseResponseBodyDataParam Param { get; set; }
            public class ApplyFileUploadLeaseResponseBodyDataParam : TeaModel {
                [NameInMap("Headers")]
                [Validation(Required=false)]
                public object Headers { get; set; }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
