// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyiotapi20171111.Models
{
    public class DoIotPostImeiResponseBody : TeaModel {
        [NameInMap("IotPostImei")]
        [Validation(Required=false)]
        public DoIotPostImeiResponseBodyIotPostImei IotPostImei { get; set; }
        public class DoIotPostImeiResponseBodyIotPostImei : TeaModel {
            [NameInMap("IsPostSuccess")]
            [Validation(Required=false)]
            public bool? IsPostSuccess { get; set; }
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
