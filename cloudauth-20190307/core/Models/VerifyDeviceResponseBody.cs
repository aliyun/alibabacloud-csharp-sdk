// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VerifyDeviceResponseBody : TeaModel {
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public VerifyDeviceResponseBodyResultObject ResultObject { get; set; }
        public class VerifyDeviceResponseBodyResultObject : TeaModel {
            [NameInMap("RetCodeSub")]
            [Validation(Required=false)]
            public string RetCodeSub { get; set; }
            [NameInMap("ProductRetCode")]
            [Validation(Required=false)]
            public string ProductRetCode { get; set; }
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public string HasNext { get; set; }
            [NameInMap("RetMessageSub")]
            [Validation(Required=false)]
            public string RetMessageSub { get; set; }
            [NameInMap("ExtParams")]
            [Validation(Required=false)]
            public string ExtParams { get; set; }
            [NameInMap("ValidationRetCode")]
            [Validation(Required=false)]
            public string ValidationRetCode { get; set; }
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
