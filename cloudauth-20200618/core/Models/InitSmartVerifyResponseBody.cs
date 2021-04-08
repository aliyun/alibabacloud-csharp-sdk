// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20200618.Models
{
    public class InitSmartVerifyResponseBody : TeaModel {
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public InitSmartVerifyResponseBodyResultObject ResultObject { get; set; }
        public class InitSmartVerifyResponseBodyResultObject : TeaModel {
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
