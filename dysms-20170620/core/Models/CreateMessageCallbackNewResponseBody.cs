// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class CreateMessageCallbackNewResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TestFailCode")]
        [Validation(Required=false)]
        public string TestFailCode { get; set; }

        [NameInMap("TestResponse")]
        [Validation(Required=false)]
        public string TestResponse { get; set; }

        [NameInMap("TestSuccess")]
        [Validation(Required=false)]
        public bool? TestSuccess { get; set; }

    }

}
