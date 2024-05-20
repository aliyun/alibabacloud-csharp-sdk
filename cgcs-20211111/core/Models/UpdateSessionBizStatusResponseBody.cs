// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class UpdateSessionBizStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateSessionBizStatusResponseBodyData Data { get; set; }
        public class UpdateSessionBizStatusResponseBodyData : TeaModel {
            [NameInMap("CustomSessionId")]
            [Validation(Required=false)]
            public string CustomSessionId { get; set; }

            [NameInMap("PlatformSessionId")]
            [Validation(Required=false)]
            public string PlatformSessionId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
