// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetUserResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetUserResponseBodyData Data { get; set; }
        public class GetUserResponseBodyData : TeaModel {
            [NameInMap("EnableEventbridge")]
            [Validation(Required=false)]
            public bool? EnableEventbridge { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
