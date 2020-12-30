// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CheckExpandStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckExpandStatusResponseBodyData Data { get; set; }
        public class CheckExpandStatusResponseBodyData : TeaModel {
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }
            [NameInMap("IsActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
