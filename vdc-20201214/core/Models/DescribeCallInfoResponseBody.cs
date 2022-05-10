// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeCallInfoResponseBody : TeaModel {
        [NameInMap("CallInfo")]
        [Validation(Required=false)]
        public DescribeCallInfoResponseBodyCallInfo CallInfo { get; set; }
        public class DescribeCallInfoResponseBodyCallInfo : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("CallStatus")]
            [Validation(Required=false)]
            public string CallStatus { get; set; }
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }
            [NameInMap("CreatedTs")]
            [Validation(Required=false)]
            public long? CreatedTs { get; set; }
            [NameInMap("DestroyedTs")]
            [Validation(Required=false)]
            public long? DestroyedTs { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
