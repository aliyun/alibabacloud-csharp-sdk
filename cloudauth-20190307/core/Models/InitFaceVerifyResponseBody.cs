// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitFaceVerifyResponseBody : TeaModel {
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
        public InitFaceVerifyResponseBodyResultObject ResultObject { get; set; }
        public class InitFaceVerifyResponseBodyResultObject : TeaModel {
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }

            [NameInMap("CertifyUrl")]
            [Validation(Required=false)]
            public string CertifyUrl { get; set; }

        }

    }

}
