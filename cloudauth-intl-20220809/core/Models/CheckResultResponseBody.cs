// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class CheckResultResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckResultResponseBodyResult Result { get; set; }
        public class CheckResultResponseBodyResult : TeaModel {
            [NameInMap("EkycResult")]
            [Validation(Required=false)]
            public string EkycResult { get; set; }

            [NameInMap("ExtBasicInfo")]
            [Validation(Required=false)]
            public string ExtBasicInfo { get; set; }

            [NameInMap("ExtFaceInfo")]
            [Validation(Required=false)]
            public string ExtFaceInfo { get; set; }

            [NameInMap("ExtIdInfo")]
            [Validation(Required=false)]
            public string ExtIdInfo { get; set; }

            [NameInMap("ExtRiskInfo")]
            [Validation(Required=false)]
            public string ExtRiskInfo { get; set; }

            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

        }

    }

}
