// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class ContrastSmartVerifyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public ContrastSmartVerifyResponseBodyResultObject ResultObject { get; set; }
        public class ContrastSmartVerifyResponseBodyResultObject : TeaModel {
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }

            [NameInMap("RiskInfo")]
            [Validation(Required=false)]
            public string RiskInfo { get; set; }

            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }

            [NameInMap("VerifyInfo")]
            [Validation(Required=false)]
            public string VerifyInfo { get; set; }

        }

    }

}
