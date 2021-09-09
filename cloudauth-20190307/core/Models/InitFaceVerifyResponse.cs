// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitFaceVerifyResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=true)]
        public InitFaceVerifyResponseResultObject ResultObject { get; set; }
        public class InitFaceVerifyResponseResultObject : TeaModel {
            [NameInMap("CertifyId")]
            [Validation(Required=true)]
            public string CertifyId { get; set; }
            [NameInMap("CertifyUrl")]
            [Validation(Required=true)]
            public string CertifyUrl { get; set; }
        };

    }

}
