// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VerifyDeviceResponse : TeaModel {
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
        public VerifyDeviceResponseResultObject ResultObject { get; set; }
        public class VerifyDeviceResponseResultObject : TeaModel {
            [NameInMap("ExtParams")]
            [Validation(Required=true)]
            public string ExtParams { get; set; }
            [NameInMap("HasNext")]
            [Validation(Required=true)]
            public string HasNext { get; set; }
            [NameInMap("ProductRetCode")]
            [Validation(Required=true)]
            public string ProductRetCode { get; set; }
            [NameInMap("RetCodeSub")]
            [Validation(Required=true)]
            public string RetCodeSub { get; set; }
            [NameInMap("RetMessageSub")]
            [Validation(Required=true)]
            public string RetMessageSub { get; set; }
            [NameInMap("ValidationRetCode")]
            [Validation(Required=true)]
            public string ValidationRetCode { get; set; }
        };

    }

}
