// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class DoIotChgBindOrUnBindResponseBody : TeaModel {
        [NameInMap("IotModBind")]
        [Validation(Required=false)]
        public DoIotChgBindOrUnBindResponseBodyIotModBind IotModBind { get; set; }
        public class DoIotChgBindOrUnBindResponseBodyIotModBind : TeaModel {
            [NameInMap("IsModSuccess")]
            [Validation(Required=false)]
            public bool? IsModSuccess { get; set; }
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
