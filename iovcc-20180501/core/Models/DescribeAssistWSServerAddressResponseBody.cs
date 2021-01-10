// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeAssistWSServerAddressResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WsServer")]
        [Validation(Required=false)]
        public string WsServer { get; set; }

        [NameInMap("OTP")]
        [Validation(Required=false)]
        public string OTP { get; set; }

    }

}
