// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeInviterResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeInviterResponseBodyResult Result { get; set; }
        public class DescribeInviterResponseBodyResult : TeaModel {
            [NameInMap("ConsortiumId")]
            [Validation(Required=false)]
            public string ConsortiumId { get; set; }

            [NameInMap("ConsortiumName")]
            [Validation(Required=false)]
            public string ConsortiumName { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("InviterId")]
            [Validation(Required=false)]
            public long? InviterId { get; set; }

            [NameInMap("InviterName")]
            [Validation(Required=false)]
            public string InviterName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
