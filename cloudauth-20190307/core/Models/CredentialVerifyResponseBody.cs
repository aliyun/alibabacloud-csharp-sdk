// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CredentialVerifyResponseBody : TeaModel {
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
        public CredentialVerifyResponseBodyResultObject ResultObject { get; set; }
        public class CredentialVerifyResponseBodyResultObject : TeaModel {
            [NameInMap("OcrInfo")]
            [Validation(Required=false)]
            public string OcrInfo { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("RiskScore")]
            [Validation(Required=false)]
            public Dictionary<string, string> RiskScore { get; set; }

            [NameInMap("RiskTag")]
            [Validation(Required=false)]
            public string RiskTag { get; set; }

            [NameInMap("VerifyDetail")]
            [Validation(Required=false)]
            public string VerifyDetail { get; set; }

            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

    }

}
