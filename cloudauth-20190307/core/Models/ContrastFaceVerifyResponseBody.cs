// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ContrastFaceVerifyResponseBody : TeaModel {
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
        public ContrastFaceVerifyResponseBodyResultObject ResultObject { get; set; }
        public class ContrastFaceVerifyResponseBodyResultObject : TeaModel {
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }
            [NameInMap("SubCode")]
            [Validation(Required=false)]
            public string SubCode { get; set; }
            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public string MaterialInfo { get; set; }
            [NameInMap("IdentityInfo")]
            [Validation(Required=false)]
            public string IdentityInfo { get; set; }
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public string Passed { get; set; }
        };

    }

}
